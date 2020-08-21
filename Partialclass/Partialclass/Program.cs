using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partialclass
{
    class Program
    {
        static void Main(string[] args)
        {
            //today i gonna show a partial class whic is also known as modifier key word we discous key word in other class here discous about all key word

            // now we call our Employe partial class here in main cos this a Filed where make a product 
            // lets debbug this code
            Employe Anewemp = new Employe(); // this new is a keyword which also a modifieer keyword
            //we make a new object thet Anewemp which can acces your partial class fild and method

            Anewemp.Empid = 23;
            Anewemp.FirstName = "Tusher";  // here we need four line
            Anewemp.LastName = "Shuvro";
            Anewemp.Email = "tushershuvro2015@gmail.com";
            // we can delever our Filed value using Myemploye method


            Anewemp.MyEmployee(245, "Alex", "Morgan", "Alexmorgan2020@gmail.com"); // we need only one line 

            // decission is your which one is really smart 

            Anewemp.DisplayEmployeAllinfo();


            Console.ReadKey();

            // ok see yea again if you jave any quistion please comment in bellow 


        }
    }
}


// first we make a partial class 
public partial class Employe
{
    //public string name;
    public int Empid { set; get; }  // we declare here Employe class filed variables
    public string FirstName { set; get; }
    public string LastName { set; get; }
    public string Email { set; get; }

    // here we make a method wich get Em id and first name

    public void MyEmployee(int id,string fname,string lname,string email ) //here MyEmploye cann help to get employe info and make sure this is a method 
    {
        this.Empid = id;
        this.FirstName = fname;
        this.LastName = lname;
        this.Email = email;
    }

    // here we make a method thed get a employe all informetion 

    public void DisplayEmployeAllinfo()
    {

        Console.WriteLine("Employe id is ="+Empid+"\n"+"Employe First name is=" 
            + FirstName+"\n"+"Employe Last name is="+LastName);
        string Fullanme = FirstName + LastName; // there is a error this way its called bottom up procedures 

        Console.WriteLine("Employe full name is="+Fullanme); // now its ok 
        Console.WriteLine("Employe email id is= "+Email);

      


    }




}
