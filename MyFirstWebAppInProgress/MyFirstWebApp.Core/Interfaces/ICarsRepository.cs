namespace MyFirstWebApp.Core.Interfaces
{
    public interface ICarsRepository<T> where T : ICarModel
    {
        IEnumerable<T> GetAllCars();
        void AddCar(T car);
        T GetById(int id);
        void Remove(int id);

    }
}
