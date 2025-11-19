// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T15 branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_1;

#region class Program -----------------------------------------------------------------------------
internal class Program {
   static void Main () {
      List<char> oldList = [];
      MyList<char> newList = new ();
      // Adding an item to the list
      oldList.Add ('i');
      oldList.Add ('n');
      oldList.Add ('d');
      oldList.Add ('u');
      newList.Add ('i');
      newList.Add ('n');
      newList.Add ('d');
      newList.Add ('u');
      // Setting an element to a specific index
      oldList[3] = 'k';
      newList[3] = 'k';
      // Removing an item from the list
      oldList.Remove ('d');
      newList.Remove ('d');
      // Inserting an item at a specific index
      oldList.Insert (1, 'm');
      newList.Insert (1, 'm');
      // Removing an item at a specific index
      oldList.RemoveAt (2);
      newList.RemoveAt (2);
      Write ("Old list elements: ");
      for (int i = 0; i < oldList.Count; i++) Write ($"{oldList[i]} ");
      WriteLine ();
      Write ("Custom list elements: ");
      for (int i = 0; i < newList.Count; i++) Write ($"{newList[i]} ");
   }
}
#endregion

#region class MyList<T> ---------------------------------------------------------------------------
class MyList<T> {

   #region Constructors----------------------------------------------
   public MyList () => InitializeStorage ();
   #endregion

   #region Properties -----------------------------------------------
   // Number of elements in the list
   public int Count => _count;

   // Gets the current storage capacity of the list
   public int Capacity => _items.Length;

   // Indexer
   public T this[int index] {
      get {
         ValidateIndex (index);
         return _items[index];
      }
      set {
         ValidateIndex (index);
         _items[index] = value;
      }
   }
   #endregion

   #region Methods -------------------------------------------
   // Add element to the end
   public void Add (T a) {
      EnsureCapacity ();
      _items[_count++] = a;
   }

   // Remove first occurrence of the element
   public bool Remove (T a) {
      int index = Array.IndexOf (_items, a, 0, _count);
      if (index == -1)
         return false;
      RemoveAt (index);
      return true;
   }

   // Clear all elements
   public void Clear () => InitializeStorage ();

   // Insert element at a given index
   public void Insert (int index, T a) {
      if (index < 0 || index > _count) throw new ArgumentOutOfRangeException (nameof (index), "Invalid index for insert.");
      EnsureCapacity ();
      for (int i = _count; i > index; i--) _items[i] = _items[i - 1];
      _items[index] = a;
      _count++;
   }

   // Remove element at a given index
   public void RemoveAt (int index) {
      if (index < 0 || index >= _count) throw new ArgumentOutOfRangeException (nameof (index), "Invalid index for removal.");
      for (int i = index; i < _count - 1; i++) _items[i] = _items[i + 1];
      _items[_count - 1] = default!; _count--;
   }
   #endregion

   #region Implementation -------------------------------------------
   // Double the capacity
   private void Resize () {
      int newCapacity = _items.Length * 2;
      T[] newArray = new T[newCapacity];
      Array.Copy (_items, newArray, _count);
      _items = newArray;
   }

   // Validates index
   private void ValidateIndex (int index) {
      if (index < 0 || index >= _count)
         throw new IndexOutOfRangeException ("Index out of range.");
   }
   #endregion

   // Initializes storage
   private void InitializeStorage () {
      _items = new T[4];
      _count = 0;
   }

   // Checks capacity and resizes if needed
   private void EnsureCapacity () {
      if (_count == _items.Length)
         Resize ();
   }

   #region Fields ---------------------------------------------------
   private T[] _items = default!;
   private int _count;
   #endregion
}
#endregion