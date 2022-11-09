
public class Person
{
    public string  Name { get; set; }
    public string  Address { get; set; }
    
    public Person(string name, string address)
    {
        this.Name = name;
        this.Address = address;
    }
    public string GetName()
    {
        return Name;
    }
    public string GetAddress()
    {
        return Address;
    }
    public void SetAddress(string address)
    {
       Address = address;
    }
   public override string ToString()
   {

         return $"{Name} , {Address}";
   }

}