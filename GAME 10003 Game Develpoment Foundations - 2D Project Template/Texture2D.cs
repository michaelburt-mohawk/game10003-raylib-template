﻿/// <summary>
///     Represents a 2D texture.
/// </summary>
/// <remarks>
///     Wrapper around Raylib.Texture2D
/// </remarks>
public readonly record struct Texture2D
{
    public Raylib_cs.Texture2D RaylibTexture2D { get; init; }

    public static implicit operator Texture2D(Raylib_cs.Texture2D raylibTexture2D)
    {
        var font = new Texture2D()
        {
            RaylibTexture2D = raylibTexture2D,
        };
        return font;
    }
    public static implicit operator Raylib_cs.Texture2D(Texture2D texture2D)
    {
        var raylibTexture2D = texture2D.RaylibTexture2D;
        return raylibTexture2D;
    }
}