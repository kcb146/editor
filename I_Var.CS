/* Model Controller / I_Var

   Created : 2011-04-13
   Last Modified : 2011-04-13
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Collections ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class I_Var
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "Var" ;
      Insert.Label = "<var>...</var>" ;

      Insert.Content += "      <var>" + nl ;
      Insert.Content += "        <name>  </name>" + nl ;
      Insert.Content += "      </var>" + nl ;

      Insert.WideContent += "      <var><name>  </name></var>" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
