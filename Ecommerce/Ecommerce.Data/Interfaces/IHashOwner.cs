namespace Ecommerce.Data.Interfaces
{
    public interface IHashOwner<T>
    {
        T OwnerId { get; set; }
    }
}
