using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Omnibox.Controls
{
    public partial class OmniboxControl: UserControl
    {
	    #region Constructors
	    public OmniboxControl()
	    {
			InitializeComponent();
		}
	    #endregion


	    #region Public Methods
	    public void AddKeywords(IEnumerable<IKeyword> keywords)
	    {
		    if (keywords == null)
		    {
			    throw new ArgumentNullException("keywords");
		    }

		    throw new NotImplementedException();
	    }
	    #endregion
    }
}
