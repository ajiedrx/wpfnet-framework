using System;
using System.Collections.Generic;
using System.Reflection;

namespace MyFramework.datastructures {
    /// <summary>
    /// Main class for MyList.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MyList<T> : List<T>
    {
        public MyList() { }

        public MyList(int capacity) : base(capacity) { }

        public MyList(IEnumerable<T> collection) : base(collection) { }
        /// <summary>
        /// Execute assigned function for each element in the list. 
        /// </summary>
        /// Below is an usage example.
        /// <example>
        /// <code>
        /// public MainWindow(){
        ///     MyList<string> listOfStrings = new MyList<string>() {
        ///         "String1", "String2", "String3"
        ///     };
        ///
        ///     listOfStrings.every(printString);
        /// }
        /// 
        /// 
        /// public void printString(string _text){
        ///     Console.WriteLine(_text);
        /// }
        /// </code>
        /// </example>
        /// Output
        /// <code>
        /// String1
        /// String2
        /// String3
        /// </code>
        /// <param name="method">An action or method param.</param>
        public void every(Action<T> method) {
            foreach (T item in this) {
                method(item);
            }
        }
        /// <summary>
        /// Filter each element in the list based on assigned function true condition then returns new filtered MyList.
        /// </summary>
        /// Below is an usage example.
        /// <example>
        /// <code>
        /// public MainWindow(){
        ///     MyList<string> countryCode = new MyList<string>() {
        ///         "ID", "IR", "IN", "IT"
        ///     };
        ///         
        ///
        ///     countryCode.filter(filterList);
        /// }   
        /// 
        /// 
        /// public bool filterList(string _str) {
        ///    if (!_str.Equals("IN")) {
        ///        return true;
        ///   }
        ///    return false;
        /// }
        /// </code>
        /// </example>
        /// Output
        /// <code>
        /// ID
        /// IR
        /// IT
        /// </code>
        /// <param name="method">A function with bool return value param.</param>
        /// <returns>MyList<T></returns>
        public MyList<T> filter(Func<T,bool> method) {
            MyList<T> newList = new MyList<T>();
            foreach (T item in this) {
                if (method(item)) {
                    newList.Add(item);
                }
            }
            return newList;
        }
        /// <summary>
        /// Removes the last element from an array and returns the value of that element.
        /// </summary>
        /// Below is an usage example.
        /// <example>
        /// <code>
        /// MyList<string> listOfStrings = new MyList<string>(){
        ///     "String1", "String2", "String3", "String4"
        /// };
        ///
        /// Console.WriteLine(listOfStrings.pop() + "\n");
        /// foreach(string string in listOfStrings){
        ///     Console.WriteLine(string);
        /// }
        /// </code>
        /// </example>
        /// Output
        /// <code>
        /// String4
        /// 
        /// String1
        /// String2
        /// String3
        /// </code>
        /// <returns>T</returns>
        public T pop() {
            T temp = this[this.Count-1];
            this.RemoveAt(this.Count-1);
            return temp;
        }
        /// <summary>
        /// Adds one or more elements to the end of an array and returns the new length of the array.
        /// </summary>
        /// Below is an usage example.
        /// <example>
        /// <code>
        /// MyList<string> listOfStrings = new MyList<string>(){
        ///     "String1", "String2", "String3", "String4"
        /// };
        ///
        /// listOfStrings.push("String5");
        /// foreach(string string in listOfStrings){
        ///     Console.WriteLine(string);
        /// }
        /// </code>
        /// </example>
        /// Output
        /// <code>
        /// String1
        /// String2
        /// String3
        /// String4
        /// String5
        /// </code>
        /// <param name="_item">An object param.</param>
        public void push(T _item) {
            this.Insert(this.Count, _item);
        }
        /// <summary>
        /// Adds one or more elements to the end of an array and returns the new length of the array.
        /// </summary>
        /// Below is an usage example.
        /// <example>
        /// <code>
        /// MyList<string> listOfStrings = new MyList<string>(){
        ///     "String1", "String2", "String3", "String4"
        /// };
        ///
        /// MyList<string> anotherListOfStrings = new MyList<string>(){
        ///     "String5", "String6"
        /// };
        ///
        /// listOfStrings.push(anotherListOfStrings);
        /// foreach(string string in listOfStrings){
        ///     Console.WriteLine(string);
        /// }
        /// </code>
        /// </example>
        /// Output
        /// <code>
        /// String1
        /// String2
        /// String3
        /// String4
        /// String5
        /// String6
        /// </code>
        /// <param name="_item">A MyList of objects param.</param>
        public void push(MyList<T> _items) {
            foreach (T item in _items) {
                this.Insert(this.Count, item);
            }
        }

    }
}
