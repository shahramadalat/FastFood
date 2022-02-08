using System;
using System.Drawing;
using System.Windows.Forms;

namespace FastFood
{
  public  class classcontrol
    {

      public static DataGridViewButtonColumn b = null;
      
      public void button_control(string name,string text)
      {
          b = new DataGridViewButtonColumn();
          b.UseColumnTextForButtonValue = true;
          b.Name=name;
          b.FlatStyle = FlatStyle.Flat;
          b.Text = text;
      }

      public static DataGridViewImageColumn i = null;
      public void image(string name,Image img)
      {
          i = new DataGridViewImageColumn();
          i.Name = name;
          i.Image = img;
          i.ImageLayout = DataGridViewImageCellLayout.Normal;
      }

    }
}
