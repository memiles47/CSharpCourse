using System;
using System.Windows.Forms;

/*
Lecture 65: Overriding Object Equals
and Get Hash Code

Lecture 66: Designing The User
interface and applying string
functions
*/

class TwoDPoint
{
    //Instance variables
    private int x;
    private int y;

    //Class constructor with arguments
    public TwoDPoint(int xCoord, int yCoord)
    {
        //Setting the instance variables
        this.x = xCoord;
        this.y = yCoord;
    }

    //Override the Equals which comes from the object class
    public override bool Equals(object obj)
    {

        /*Ensuring that obj is not null
        and that the types of objects are of the same type*/
        if (obj == null || this.GetType() != obj.GetType()) 
        {
            return false;
        }
        else
        {
            //Converts to a TwoDPoint with a cast
            TwoDPoint point = (TwoDPoint)obj;

            /*Ensuring the x components and y components
            are the same, returning a true*/
            return this.x == point.x && this.y == point.y;
        }
    }

    public override int GetHashCode()
    {
        /*
        This method uses Xor (exclusive or) to ensure
        that the comparison of objects works well.
        ^ is the 'exclusive or' operator
        here. It is generating a hash code for our
        objects from the two fields that make up
        each object
        */
        return x ^ y;
    }
}

class PointComparer
{
    //Create Graphical components, controls
    static Form frm = new Form();
    static TextBox tb1 = new TextBox();
    static TextBox tb2 = new TextBox();
    static Label lbl = new Label();
    static Button btn = new Button();

    //Initialize and place the controls into the form
    public static void InitializeComponents()
    {
        //Initialize the controls
        frm.Controls.Add(tb1);
        frm.Controls.Add(tb2);
        frm.Controls.Add(lbl);
        frm.Controls.Add(btn);

        //Place the controls
        int topPos = 50;
        foreach (Control c in frm.Controls)
        {
            c.Left = 50;
            c.Top = topPos;
            topPos += 25;
        }

        btn.Click += Btn_Click;
        btn.Text = "Compare";
        lbl.AutoSize = true;
    }

    private static void Btn_Click(object sender, EventArgs e)
    {
        //Temp variable for use in TryParse
        int temp;

        //Split out x and y of first text box into a string array, first[]
        string[] first = tb1.Text.Split(new char[] { '(', ',', ')' }, StringSplitOptions.RemoveEmptyEntries);

        //Construct x and y coordinates for the first point from the first array
        int p1x = int.TryParse(first[0], out temp) ? temp : 0;
        int p1y = int.TryParse(first[1], out temp) ? temp : 0;

        //Split out x and y of second text box into a string array, second[]
        string[] second = tb2.Text.Split(new char[] { '(', ',', ')' }, StringSplitOptions.RemoveEmptyEntries);

        //Construct x and y coordinates for the second point from the second array
        int p2x = int.TryParse(second[0], out temp) ? temp : 0;
        int p2y = int.TryParse(second[1], out temp) ? temp : 0;

        //Create our TwoDPoints
        TwoDPoint p1 = new TwoDPoint(p1x, p1y);
        TwoDPoint p2 = new TwoDPoint(p2x, p2y);

        //Display result of the Equals object method we overrode
        lbl.Text = $"Comparison is: {p1.Equals(p2)}";
        
    }

    static void Main()
    {
        InitializeComponents();
        Application.Run(frm);
    }
}