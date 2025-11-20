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
      List<char> list = [];
      MyList<char> myList = new ();
      // Adding an item to the list
      string word = "indu";
      foreach (char ch in word) {
         list.Add (ch);
         myList.Add (ch);
      }
      WriteLine ($"After adding 'indu': list Count = {list.Count}, myList Count = {myList.Count}");
      // Setting an element to a specific index
      list[3] = 'k';
      myList[3] = 'k';
      WriteLine ($"After setting index 3 to 'k': list[3] = {list[3]}, myList[3] = {myList[3]}");
      // Removing an item from the list
      list.Remove ('d');
      myList.Remove ('d');
      WriteLine ($"After removing 'd': list Count = {list.Count}, myList Count = {myList.Count}");
      // Inserting an item at a specific index
      list.Insert (1, 'm');
      myList.Insert (1, 'm');
      WriteLine ($"After inserting 'm' at index 1: list[1] = {list[1]}, myList[1] = {myList[1]}");
      // Removing an item at a specific index
      list.RemoveAt (2);
      myList.RemoveAt (2);
      WriteLine ($"After removing at index 2,list Count = {list.Count}, myList Count = {myList.Count} ");
      list.Clear ();
      myList.Clear ();
      WriteLine ($"After clearing: list Count = {list.Count}; myList Count = {myList.Count}");
   }
}
#endregion

#region class MyList<T> ---------------------------------------------------------------------------
class MyList<T> {

   #region Constructors----------------------------------------------
   public MyList () => Init ();
   #endregion

   #region Properties -----------------------------------------------
   /// <summary> Gets the total number of elements the list can hold before needing to resize its storage</summary>
   public int Capacity => _items.Length;

   /// <summary> Gets the number of elements currently in the list </summary>
   public int Count => _count;

   /// <summary> Gets or sets the element at the specified index in the list.</summary>
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

   #region Methods --------------------------------------------------
   /// <summary>Adds the specified element to the end of the collection.</summary>
   public void Add (T a) {
      Resize ();
      _items[_count++] = a;
   }

   /// <summary> Clears the current state and reinitializes the object to its default state.</summary>
   public void Clear () => Init ();

   /// <summary> Inserts the specified element at the given index in the collection.</summary>
   public void Insert (int index, T a) {
      if (index < 0 || index > _count) throw new IndexOutOfRangeException ("Index out of range");
      Resize ();
      for (int i = _count; i > index; i--) _items[i] = _items[i - 1];
      _items[index] = a;
      _count++;
   }

   /// <summary> Removes the first occurrence of the specified element from the list.</summary>
   public bool Remove (T a) {
      int index = Array.IndexOf (_items, a, 0, _count);
      if (index == -1)
         return false;
      RemoveAt (index);
      return true;
   }

   /// <summary>Removes the element at the specified index from the collection.</summary>
   public void RemoveAt (int index) {
      ValidateIndex (index);
      for (int i = index; i < _count - 1; i++) _items[i] = _items[i + 1];
      _items[_count - 1] = default!; _count--;
   }
   #endregion

   #region Implementation -------------------------------------------
   // Initializes storage
   void Init () {
      _items = new T[4];
      _count = 0;
   }

   // Checks and resizes storage if needed
   void Resize () {
      if (_count != _items.Length) return;
      T[] newArray = new T[_items.Length * 2];
      Array.Copy (_items, newArray, _count);
      _items = newArray;
   }

   // Validates index
   void ValidateIndex (int index) {
      if (index < 0 || index >= _count)
         throw new IndexOutOfRangeException ("Index out of range.");
   }
   #endregion

   #region Private Data ---------------------------------------------
   private int _count;
   private T[] _items = default!;
   #endregion
}
#endregion