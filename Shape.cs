namespace Mindbox
{
    public abstract class Shape
    {
        public abstract float GetArea();
    }

    public class Circle : Shape
    {
        public float Radius { get; set; }

        public Circle()
        {

        }

        public Circle(float radius)
        {
            Radius = radius;
        }

        public override float GetArea()
        {
            return MathF.Pow(Radius, 2) * MathF.PI;
        }
    }

    public class Triangle : Shape
    {
        public float SideA { get; set; }
        public float SideB { get; set; }
        public float SideC { get; set; }

        public Triangle()
        {

        }

        public Triangle(float sideA, float sideB, float sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override float GetArea()
        {
            float area;

            if (MathF.Pow(SideA, 2) == MathF.Pow(SideB, 2) + MathF.Pow(SideC, 2))
            {
                area = SideB * SideC / 2;
            }
            else if(MathF.Pow(SideB, 2) == MathF.Pow(SideA, 2) + MathF.Pow(SideC, 2))
            {
                area = SideA * SideC / 2;
            }
            else if (MathF.Pow(SideC, 2) == MathF.Pow(SideA, 2) + MathF.Pow(SideB, 2))
            {
                area = SideA * SideB / 2;
            }
            else
            {
                float semiPerimeter = (SideA + SideB + SideC)/2;
                area = MathF.Sqrt(semiPerimeter *(semiPerimeter - SideA)*(semiPerimeter - SideB)*(semiPerimeter - SideC));
            }
            return area;
        }
    }
}