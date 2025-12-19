namespace CloudShop.Domain;

public class Product
{
  public Guid Id { get; private set; }
  public string Name { get; private set; }
  public decimal Price { get; private set; }

  public Product(string name, decimal price){
    if(price < 0) throw new ArgumentException("Price cannot be negative");
    Id = Guid.NewGuid();
    Name = name; 
    Price = price;
  }
}

// Blueprint for every product
// Price cannot be negative 
// Private setters 
