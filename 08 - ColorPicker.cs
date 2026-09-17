[  ] using System.Windows.Forms;
[  ] 
[  ] public static class ColorPicker
[  ] {
[  ]     public static string Pick()
[  ]     {
[  ]         var dialog = new ColorDialog();
[  ] 
[  ]         if (dialog.ShowDialog() == DialogResult.OK)
[  ]         {
[  ]             var c = dialog.Color;
[  ]             return $"#{c.R:X2}{c.G:X2}{c.B:X2}";
[  ]         }
[  ] 
[  ]         return null;
[  ]     }
[  ] }