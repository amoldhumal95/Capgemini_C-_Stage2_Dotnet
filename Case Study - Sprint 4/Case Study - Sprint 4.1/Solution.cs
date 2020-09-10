using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;
using System.Linq;


	//Section A
	class Customer
	{
	  //Write your code here 
	  int cid;
	  string cname;
	  string password;
	  string city;
	  string state;
	  string zip;
	  string country;
	  //Regex rx = new Regex("^[a-zA-Z]*$", RegexOptions.Compiled);

	  public int Cid
    	  {  
    	   get 
    	  { return cid;}
    	      set
    	   {cid=value;  }}
            public string Cname
    	  {  
    	      get 
    	      { return cname;}
    	      set{
    	          //if (cname.Length <6 || !rx.IsMatch(cname)){
    	            //  cname = "not_valid";
    	              //throw new InvalidAgeException();}
    	          //else{
    	          cname=value;  }}//}
    	    public string Password
    	  {  get { return password;}
    	      set{password=value;  }}
    	    public string City
    	  {  get { return city;}
    	      set{city=value;  }}
    	    public string State
    	  {  get { return state;}
    	      set{state=value;  }}
    	    public string Zip
    	  {  get { return zip;}
    	      set{zip=value;  }}
    	    public string Country
    	  {  get { return country;}
    	      set{country=value;  }
    	  }

	  public Customer(){

	  }
	  public Customer(int cid,string cname,string password,string city,string state,string zip,string country){
	      try
	  {
	      if(cname.Length<6)
	      {
	          throw new InvalidNameException("Invalid Name");
	      }
	  }
	      catch(InvalidNameException o)
	      {
	          Console.WriteLine("InvalidName");
	          Console.WriteLine(o.Message);
	      }
	      catch(Exception){return;}
    	  this.cname = cname; 
    	  this.cid = cid;
	      this.password = password;
	      this.city = city;
	      this.state = state;
	      this.zip = zip;
	      this.country = country;
	  }
	  public override string ToString(){
	      return "CustomerId-"+cid+",CustomerName-"+cname+",Password-"+password+",City-"+city+",State-"+state+",Zip-"+zip+",Country-"+country;
	  }
	}
//Section B	

        class Toy 
	{
	    private int? tid;
	    private string tname;
	    private string type;
	    private int? min_age;
	    private int? max_age;
	    private float? price;
	    private int? quantity;
	    private double? rental_amount;
	    public Toy()
	    {}
	   public  Toy(int h,string i,string j,int k,int l,float m,int o,double n)
	  {
	      try
	  {
	      if(k<0 ||l>12)
	      {
	          throw new InvalidAgeException("InvalidAgeException");
	      }
	  }
	      catch(InvalidAgeException p)
	      {
	          Console.WriteLine("InvalidAgeException");
	          Console.WriteLine(p.Message);
	          return;
	      }
	    catch(Exception){return;}
	      tid=h;
	      tname=i;
	      type=j;
	      min_age=k;
	      max_age=l;
	      price=m;
	      quantity=o;
	      rental_amount=n;

	  }
	   public int? Tid
	  {  get { return tid;}
	      set{tid=value;  }}
public string Tname
	  {  get { return tname;}
	      set{tname=value;  }}
	      public string Type
	  {  get { return type;}
	      set{type=value;  }}
	      public int? Min_age
	  {  get { return min_age;}
	      set{min_age=value;  }}
	      public int? Max_age
	  {  get { return max_age;}
	      set{max_age=value;  }}
	      public float? Price
	  {  get { return price;}
	      set{price=value;  }}
	      	      public int? Quantity
	  {  get { return quantity;}
	      set{quantity=value;  }}
	      public double? Rental_amount
	  {  get { return rental_amount;}
	      set{rental_amount=value;  }}
	      public override string ToString(){

    string s="ToyId-"+tid.ToString()+",ToyName-"+tname+",Type-"+type+",MinAge-"+min_age.ToString()+",MaxAge-"+max_age.ToString()+",Price-"+price.ToString()+",Quantity-"+quantity.ToString()+",RentalAmount-"+rental_amount.ToString();
//Console.Write(s);
return s;
}
}
	//write your Exception classes implimentations here 
    public class InvalidNameException: Exception{
	    public InvalidNameException(){}
	    public InvalidNameException(string message): base(message) {}
	    public InvalidNameException(string Message, Exception inner): base(Message, inner) {}
	}

	class InvalidAgeException: Exception {  
        public InvalidAgeException(string Message): base(Message) {}  
        public InvalidAgeException() {}  
        public InvalidAgeException(string Message, Exception inner): base(Message, inner) {}  
    }
