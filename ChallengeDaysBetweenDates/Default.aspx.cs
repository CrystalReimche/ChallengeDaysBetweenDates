using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void okButton_Click(object sender, EventArgs e)
    {
        if (myCalendar2.SelectedDate > myCalendar1.SelectedDate)
        {
            resultLabel.Text = (myCalendar2.SelectedDate - myCalendar1.SelectedDate).TotalDays.ToString();
        }
        else
        {
            resultLabel.Text = (myCalendar1.SelectedDate - myCalendar2.SelectedDate).TotalDays.ToString();
        }
        
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        //resultLabel.Text = myCalendar1.SelectedDate.ToShortDateString();
    }
}