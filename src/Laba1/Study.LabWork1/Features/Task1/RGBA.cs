using System;
using System.Collections.Generic;
using System.Text;

namespace Study.LabWork1.Features.Task1
{
    /// <summary>
    /// RGBA class
    /// </summary>
    public class RGBA
    {
        private byte red;
        private byte green;
        private byte blue;
        private float alpha;

        /// <summary>
        /// Красный канал
        /// </summary>
        public byte Red
        {
            get => red;
            set => red = Clamp(value);
        }

        /// <summary>
        /// Зеленый канал
        /// </summary>
        public byte Green
        {
            get => green;
            set => green = Clamp(value);
        }

        /// <summary>
        /// Синий канал
        /// </summary>
        public byte Blue
        {
            get => blue;
            set => blue = Clamp(value);
        }

        /// <summary>
        /// Прозрасность
        /// </summary>
        public float Alpha
        {
            get => alpha;
            set => alpha = ClampFloat(value);
        }

        /// <summary>
        /// создаём новый RGBA пиксель
        /// </summary>
        /// <param name="r"></param>
        /// <param name="g"></param>
        /// <param name="b"></param>
        /// <param name="a"></param>
        public RGBA(byte r, byte g, byte b, float a)
        {
            Red = r;
            Green = g;
            Blue = b;
            Alpha = a;
        }

        /// <summary>
        /// Ограничиваем значение канала в диапозоне 0 - 255
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static byte Clamp(int value)
        {
            return (byte)Math.Max(0, Math.Min(255, value));
        }

        /// <summary>
        /// Ограничиваем значение Альфв-канала в диапазоне 0 - 1
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static float ClampFloat(float value)
        {
            return Math.Max(0f, Math.Min(1f, value));
        }

        /// <summary>
        /// Сложение двух пикселей
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static RGBA operator +(RGBA a, RGBA b)
        {
            return new RGBA(
                Clamp(a.Red + b.Red),
                Clamp(a.Green + b.Green),
                Clamp(a.Blue + b.Blue),
                ClampFloat(a.Alpha + b.Alpha)
            );
        }

        /// <summary>
        /// Вычитание двух пикселей
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static RGBA operator -(RGBA a, RGBA b)
        {
            return new RGBA(
                Clamp(a.Red - b.Red),
                Clamp(a.Green - b.Green),
                Clamp(a.Blue - b.Blue),
                ClampFloat(a.Alpha - b.Alpha)
            );
        }

        /// <summary>
        /// Умножение пикселя на скаляр
        /// </summary>
        /// <param name="a"></param>
        /// <param name="scalar"></param>
        /// <returns></returns>
        public static RGBA operator *(RGBA a, float scalar)
        {
            return new RGBA(
                Clamp((int)(a.Red * scalar)),
                Clamp((int)(a.Green * scalar)),
                Clamp((int)(a.Blue * scalar)),
                ClampFloat(a.Alpha * scalar)
            );
        }

        /// <summary>
        /// Умножение двух пикселей
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static RGBA operator *(RGBA a, RGBA b)
        {
            return new RGBA(
                Clamp(a.Red * b.Red / 255),
                Clamp(a.Green * b.Green / 255),
                Clamp(a.Blue * b.Blue / 255),
                ClampFloat(a.Alpha * b.Alpha)
            );
        }

        /// <summary>
        /// Проверка равенства двух пикселей
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(RGBA a, RGBA b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;

            return a.Red == b.Red &&
                   a.Green == b.Green &&
                   a.Blue == b.Blue &&
                   Math.Abs(a.Alpha - b.Alpha) < 0.0001f;
        }

        /// <summary>
        /// Проверка неравенста двух пикселей
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator !=(RGBA a, RGBA b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Сравнение с другим объектом
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is RGBA other && this == other;
        }


        /// <summary>
        /// Возращает хэш код 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Red, Green, Blue, Alpha);
        }

        /// <summary>
        /// Возращает строку rgba(r, g, b, a)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"rgba({Red}, {Green}, {Blue}, {Alpha})";
        }

        /// <summary>
        /// Возвращает цвет в HEX-формате
        /// </summary>
        /// <returns></returns>
        public string ToHex()
        {
            return $"#{Red:X2}{Green:X2}{Blue:X2}";
        }
    }
}
