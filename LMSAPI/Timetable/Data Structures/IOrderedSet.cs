namespace LMSAPI.Timetable.Data_Structures
{
    public interface IOrderedSet<T> where T: IComparable
    {
        void Show();
        IOrderedSet<T> MakeCopy();

        bool Contains(T item);
        bool CanAdd(T newItem);
        bool Add(T newItem);
        bool Delete(T item);

        List<T> GetContents();
    }
}
