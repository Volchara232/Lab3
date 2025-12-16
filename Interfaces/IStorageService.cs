using System.Collections.Generic;
using Models;

namespace Interfaces
{
    public interface IStorageService
    {
        void SaveGame(GameState gameState, string filePath);
        GameState LoadGame(string filePath);
    }
}