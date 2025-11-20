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
   /// <summary> Total number of elements the list can hold </summary>
   public int Capacity => mData.Length;

   /// <summary> Number of elements currently in the list </summary>
   public int Count => mCount;

   /// <summary> Gets or sets the element at the specified index in the list </summary>
   public T this[int index] {
      get {
         ValidateIndex (index);
         return mData[index];
      }
      set {
         ValidateIndex (index);
         mData[index] = value;
      }
   }
   #endregion

   #region Methods --------------------------------------------------
   /// <summary>Adds the given element to the list </summary>
   public void Add (T a) {
      Resize ();
      mData[mCount++] = a;
   }

   /// <summary> Reinitializes the list </summary>
   public void Clear () => Init ();

   /// <summary> Inserts the specified element at the given index in the collection </summary>
   public void Insert (int index, T a) {
      if (index < 0 || index > mCount) throw new IndexOutOfRangeException ("Index out of range");
      Resize ();
      for (int i = mCount; i > index; i--) mData[i] = mData[i - 1];
      mData[index] = a;
      mCount++;
   }

   /// <summary> Removes the first occurrence of the specified element from the list </summary>
   public bool Remove (T a) {
      int index = Array.IndexOf (mData, a, 0, mCount);
      if (index == -1)
         return false;
      RemoveAt (index);
      return true;
   }

   /// <summary>Removes the element at the specified index from the collection </summary>
   public void RemoveAt (int index) {
      ValidateIndex (index);
      for (int i = index; i < mCount - 1; i++) mData[i] = mData[i + 1];
      mData[mCount - 1] = default!; mCount--;
   }
   #endregion

   #region Implementation -------------------------------------------
   // Initializes storage
   void Init () {
      mData = new T[4];
      mCount = 0;
   }

   // Checks and resizes storage if needed
   void Resize () {
      if (mCount != mData.Length) return;
      T[] newArray = new T[mData.Length * 2];
      Array.Copy (mData, newArray, mCount);
      mData = newArray;
   }

   // Validates index
   void ValidateIndex (int index) {
      if (index < 0 || index >= mCount)
         throw new IndexOutOfRangeException ("Index out of range.");
   }
   #endregion

   #region Private Data ---------------------------------------------
   private int mCount;
   private T[] mData = default!;
   #endregion
}
#endregion