using Tut2_s25807;

namespace Tut2_s25807_Tests
{
    public class Tests
    {
        //SPHERE
        private readonly IShape sphere = new Sphere(5);

        [Test]
        public void TestSphereCalculateArea()
        {
            Assert.That(sphere.CalculateArea(), Is.EqualTo(314.159).Within(0.001));
        }

        [Test]
        public void TestSphereCalculateVolume()
        {
            Assert.That(sphere.CalculateVolume(), Is.EqualTo(523.598).Within(0.001));
        }

        //CYLINDER
        private readonly IShape cylinder = new Cylinder(3, 7);

        [Test]
        public void TestCylinderCalculateArea()
        {
            Assert.That(cylinder.CalculateArea(), Is.EqualTo(188.495).Within(0.001));
        }

        [Test]
        public void TestCylinderCalculateVolume()
        {
            Assert.That(cylinder.CalculateVolume(), Is.EqualTo(197.92).Within(0.001));
        }
        
        //RECTANGLE
        private readonly IShape rectangle = new Rectangle(4, 8);

        [Test]
        public void TestRectangleCalculateArea()
        {
            Assert.That(rectangle.CalculateArea(), Is.EqualTo(32).Within(0.001));
        }

        [Test]
        public void TestRectangleCalculateVolume()
        {
            Assert.That(rectangle.CalculateVolume(), Is.EqualTo(0).Within(0.001));
        }
        
        //CUBE
        private readonly IShape cube = new Cube(4);

        [Test]
        public void TestCubeCalculateArea()
        {
            Assert.That(cube.CalculateArea(), Is.EqualTo(96).Within(0.001));
        }

        [Test]
        public void TestCubeCalculateVolume()
        {
            Assert.That(cube.CalculateVolume(), Is.EqualTo(64).Within(0.001));
        }
    }
}