namespace CalculatorApp
{
    public class PaymentService
    {
<<<<<<< HEAD
        public bool ProcessPayment(object payment)
{
    if (payment == null)
        return false;

    return true;
=======
public bool ProcessPayment(object payment)
{
    if (payment == null)
        return false;

    return payment != null;
}


    }
}
