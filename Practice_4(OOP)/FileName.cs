internal class Person
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Surname { get; set; }

    private int balance { get; set; }

    public int Balance
    {
        get
        {
            return balance;
        }

        set
        {
            if (value > 1200 || value < 100)
            {
                throw new Exception("Error");

            }
            else
            {
                balance = value;
            }
        }
    }


}
