using System.Text.Json;

namespace use_case_1;

public class DbContext
{
    public List<User> Users = new();
    public List<Product> Products = new();

    public DbContext()
    {
        var dbText = File.ReadAllText("Db.json");
        var db = JsonSerializer.Deserialize<Db>(dbText);
        if (db != null)
        {
            Users = db.Users;
            Products = db.Products;
        }
    }

    public void UpdateUser(User user)
    {
        var existingUser = Users.Find(u => u.Id == user.Id);
        if (existingUser != null)
        {
            Users.Remove(existingUser);
        }

        Users.Add(user);
    }
}
