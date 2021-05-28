using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Q1
{
    class Program
    {
        public static void Q1_Main()
        {
            PhotoStudio ps = new PhotoStudio();
            List<Image> list = new List<Image>()
            {
                new Jpeg(),
                new Jpeg(),
                new Jpeg(),
                new Jpeg(),
                new Jpeg(),
                new Jpeg()
            };
            ps.PlaceOrder(list, PhotoType.Jpeg);
            var v = ps.GetGrayScaleAlbum();
            foreach (var temp in v)
                Console.WriteLine(temp.GetType());
            Console.ReadLine();
        }
    }
    enum PhotoType { Jpeg, Png };
    class Image { }
    class Jpeg : Image { } /* represents a JPEG file */
    class Png : Image { } /* represents a PNG file */
    abstract class Filter
    {
        public abstract Image GrayScale(Image img);
    }
    class JpegFilter : Filter
    {
        public override Image GrayScale(Image jpeg)
        {
            /*convert to grayscale*/
            Console.WriteLine("jpg");
            return jpeg;
        }
    }
    class PngFilter : Filter
    {
        public override Image GrayScale(Image png)
        {
            /*convert to grayscale*/
            Console.WriteLine("png");
            return png;
        }
    }

    class PhotoStudio
    {
        private Filter filter;
        private List<Image> images;
        public void PlaceOrder(List<Image> photos, PhotoType image)
        {
            switch (image)
            {
                case PhotoType.Jpeg:
                    filter = new JpegFilter();
                    break;
                case PhotoType.Png:
                    filter = new PngFilter();
                    break;
            }
            images = photos;
        }
        public List<Image> GetGrayScaleAlbum()
        {
            List<Image> album = new List<Image>();
            foreach (var photo in images)
                album.Add(filter.GrayScale(photo));
            return album;
        }
    }
}

namespace Q2
{
    class Embassy
    {
        public static void Q2_Main()
        {
            List<Applicant> applicants = new List<Applicant>()
            { new Applicant(1), new Applicant(2)};
            VisaProcessor visaProcessor = new VisaProcessor();
            visaProcessor.SetCallbackForVisaStatus(
                () => { Console.WriteLine("Function CalledBack!!"); }
            );
            foreach (var applicant in applicants)
                visaProcessor.ProcessVisa(applicant);
            Console.ReadLine();
        }
    }
    class Applicant
    {
        public Applicant(int ID) { this.ID = ID; }
        public int ID { get; }
    }
    class VisaProcessor
    {
        public delegate void MyCallBack();
        public void SetCallbackForVisaStatus(MyCallBack callBackObj)
        {
            callBackObj();
        }

        public void ProcessVisa(Applicant applicant)
        {
            Console.WriteLine("Applicant Id: {0}, Status: {1}", applicant.ID, "Approved");
        }
    }
}

namespace Q3
{
    class TestBoxing
    {
        static void Q3_Main()
        {
            int i = 123;
            object o = i;   //Boxing
            i = 456;
            int j = (int)o;     //Unboxing
            System.Console.WriteLine(i);
            System.Console.WriteLine(j);
        }
    }
}

namespace Q4
{
    /*
     Here, we are violating following principles of SOLID:
    Open Closed Principle:
        Here, we didn't consider what would happen if a
        specific type of animal is to be introduced like reptile or mammal
    Interface Segregation Principle:
        Here, the interfaces weren't segregated properly before which we fix in our code
    */
    class Program
    {
        static void Q4_Main()
        {
            Fish f = new Fish();
            f.Breathe();
            f.Swim();
            Console.ReadLine();
        }
    }

    abstract class IAnimal
    {
        public virtual void Breathe() {/* breathe */}
    }

    abstract class ILandAnimal : IAnimal
    {
        public virtual void Walk() { /* walk */}
    }

    abstract class IWaterAnimal : IAnimal
    {
        public virtual void Swim() { /* swim */}
    }

    class Fish : IWaterAnimal
    {
    }
    class Bull : ILandAnimal
    {
    }
}
namespace In_Sem_II
{
    class Program
    {
        static void Main(string[] args)
        {
            //Execute.
        }
    }
}
