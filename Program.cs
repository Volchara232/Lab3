using System;
using System.Drawing;
using Models;
using Storage;

namespace Arkanoid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arkanoid Game Logic Test");
            
            // Тест создания объектов
            var ball = new Ball(100, 100, 10, new Speed(5, 45), Color.White);
            var brick = new Brick(50, 50, 3, Color.Red);
            var platform = new Platform(300, 550, 120, Color.Green);
            
            Console.WriteLine($"Ball created at ({ball.X}, {ball.Y})");
            Console.WriteLine($"Brick created with strength: {brick.Strength}");
            Console.WriteLine($"Platform size: {platform.Size}");
            
            // Тест сериализации
            var storage = new JsonStorageService();
            var gameState = new GameState
            {
                Score = 1000,
                Lives = 3,
                Level = 1,
                Platform = platform,
                Balls = { ball },
                Bricks = { brick }
            };
            
            var savePath = "test_save.json";
            storage.SaveGame(gameState, savePath);
            Console.WriteLine($"Game saved to {savePath}");
            
            // Тест загрузки
            try
            {
                var loadedState = storage.LoadGame(savePath);
                if (loadedState != null)
                {
                    Console.WriteLine($"Game loaded. Score: {loadedState.Score}, Lives: {loadedState.Lives}");
                    Console.WriteLine($"Loaded balls: {loadedState.Balls?.Count ?? 0}");
                    Console.WriteLine($"Loaded bricks: {loadedState.Bricks?.Count ?? 0}");
                }
                else
                {
                    Console.WriteLine("Failed to load game: loadedState is null");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading game: {ex.Message}");
            }
            
            // Очистка
            try
            {
                if (File.Exists(savePath))
                    File.Delete(savePath);
                Console.WriteLine("Test file deleted.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting test file: {ex.Message}");
            }
            
            Console.WriteLine("Test completed!");
        }
    }
}