using System;
using System.Drawing;
using Models;
namespace Interfaces
{
    public interface IGameObject
    {
        int X { get; set; }
        int Y { get; set; }
        Color Color { get; set; }
        string Type { get; }
    }
}