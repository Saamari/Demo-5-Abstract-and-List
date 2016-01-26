using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_5_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            //DrawingObject do = new DrawingObject();

            Circle circle = new Circle();
            circle.Name = "My Circle"; // Draw Circle
            circle.Draw();

            Square square = new Square();
            square.Name = "My Square";
            square.Draw();


            // create a List Collection to drawing object
            List<DrawingObject> drawingObjects = new List<DrawingObject>();
            // add few objects to collection
            drawingObjects.Add(new Circle());
            drawingObjects.Add(new Square());
            drawingObjects.Add(new Circle());
            drawingObjects.Add(new Square());
            drawingObjects.Add(new Circle());
            drawingObjects.Add(new Square());
            drawingObjects.Add(new Circle());
            drawingObjects.Add(new Square());

            //loop collection and draw objects
            Console.WriteLine("Drawing objects in List");
            foreach (DrawingObject drawingObject in drawingObjects)
            {
                drawingObject.Draw();
            }


            Console.WriteLine("Press something to continue");
            Console.ReadLine();



        }
    }
}
