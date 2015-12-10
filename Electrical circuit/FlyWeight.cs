using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Electrical_circuit;

namespace Electrical_circuit
{
   
    public class ElementsUser 
    {
        public List<AbstractFactory> Elements { get; set; }
        public Image WireImage { get; set; }
	    public Image ResistanceImage {get; set;}
	    public Image CurrentSourceImage {get; set;}
        public Image CornerWireImage { get; set; }

        public ElementsUser()
        {
            WireImage = new Image();
            WireImage.Source = new BitmapImage(new Uri(@"Pictures/Wire.png")) ;
            ResistanceImage = new Image();
            ResistanceImage.Source = new BitmapImage(new Uri(@"Pictures/Resistance.png"));
            CurrentSourceImage = new Image();
            CurrentSourceImage.Source = new BitmapImage(new Uri(@"Pictures/Current_source.png"));
            CornerWireImage.Source = new BitmapImage(new Uri(@"Pictures/corner_wire.png"));
        }
    }

    public class MyWireImage
    {
        
    }

    public class MyResistanceImage
    {
        
    }

    public class MyCurrentSourceImage
    {
        
    }


    public class Images
    {

        public Image ResistanceImage { get; set; }
        public Image WireImage { get; set; }
        public Image CurrentSourceImage { get; set; }
        
    }

}