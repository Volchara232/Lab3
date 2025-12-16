using System;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Interfaces;
using Models;

namespace Storage
{
    public class JsonStorageService : IStorageService
    {
        private readonly JsonSerializerOptions _options;
        
        public JsonStorageService()
        {
            _options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new JsonStringEnumConverter(), new ColorConverter() }
            };
        }
        
        public void SaveGame(GameState gameState, string filePath)
        {
            try
            {
                var json = JsonSerializer.Serialize(gameState, _options);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Ошибка при сохранении игры: {ex.Message}", ex);
            }
        }
        
        public GameState LoadGame(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                    throw new FileNotFoundException("Файл сохранения не найден", filePath);
                
                var json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<GameState>(json, _options);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Ошибка при загрузке игры: {ex.Message}", ex);
            }
        }
    }
    
    public class ColorConverter : JsonConverter<Color>
    {
        public override Color Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var colorString = reader.GetString();
            return ColorTranslator.FromHtml(colorString);
        }
        
        public override void Write(Utf8JsonWriter writer, Color value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(ColorTranslator.ToHtml(value));
        }
    }
}