using NUnit.Framework;

namespace TestTaskMindBox.Tests
{
    public class ShapeTests
    {
        /// <summary>
        /// Проверка корректности вычисления площади круга при корректных данных
        /// </summary>
        [Test]
        public void Circle_ReturnsCorrectArea()
        {
            double radius = 5;
            CircleShape circle = new CircleShape(radius);

            double area = circle.CalculateArea();

            Assert.AreEqual(Math.PI * Math.Pow(radius, 2), area);
        }

        /// <summary>
        /// Проверка корректности вычисления площади круга при некорректных данных (радиус меньше 0)
        /// </summary>
        [Test]
        public void Circle_ReturnsRadiusLessZeroException()
        {
            double radius = -5;
            CircleShape circle = new CircleShape(radius);

            Assert.Throws<ArgumentException>(() => circle.CalculateArea());
        }

        /// <summary>
        /// Проверка корректности вычисления площади треугольника при корректных данных
        /// </summary>
        [Test]
        public void Triangle_ReturnsCorrectArea()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            TriangleShape triangle = new TriangleShape(sideA, sideB, sideC);

            double area = triangle.CalculateArea();

            Assert.AreEqual(6, area);
        }

        /// <summary>
        /// Проверка корректности вычисления площади треугольника при некорректных данных (одна из сторон меньше 0)
        /// </summary>
        [Test]
        public void Triangle_ReturnsSideLessZeroException()
        {
            double sideA = -3;
            double sideB = 4;
            double sideC = 5;
            TriangleShape triangle = new TriangleShape(sideA, sideB, sideC);

            Assert.Throws<ArgumentException>(() => triangle.CalculateArea());
        }

        /// <summary>
        /// Проверка корректности вычисления площади треугольника при некорректных данных (не выполнено условие существоавания)
        /// </summary>
        [Test]
        public void Triangle_ReturnsNonExistingException()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 9;
            TriangleShape triangle = new TriangleShape(sideA, sideB, sideC);

            Assert.Throws<ArgumentException>(() => triangle.CalculateArea());
        }

        /// <summary>
        /// Проверка треугольника на правильность (треугольник правильный)
        /// </summary>
        [Test]
        public void Triangle_IsRightAngleTrue()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            TriangleShape triangle = new TriangleShape(sideA, sideB, sideC);

            Assert.IsTrue(triangle.IsRightAngle());
        }

        /// <summary>
        /// Проверка треугольника на правильность (треугольник неправильный)
        /// </summary>
        [Test]
        public void Triangle_IsRightAngleFalse()
        {
            double sideA = 2;
            double sideB = 3;
            double sideC = 4;
            TriangleShape triangle = new TriangleShape(sideA, sideB, sideC);

            Assert.IsFalse(triangle.IsRightAngle());
        }
    }
}