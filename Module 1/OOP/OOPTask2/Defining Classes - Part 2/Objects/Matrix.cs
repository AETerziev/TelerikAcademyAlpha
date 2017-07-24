using System;

namespace Defining_Classes___Part_2
{
    public class Matrix<T>
        where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
    {
        private T[,] elements;


        public T this[int row, int col]
        {
            get
            {
                if (row < 0 || row >= this.elements.GetLength(0) || col < 0 || col >= this.elements.GetLength(1))
                {
                    throw new IndexOutOfRangeException("Index is invalid");
                }

                return this.elements[row, col];
            }
            set
            {
                if (row < 0 || row >= this.elements.GetLength(0) || col < 0 || col >= this.elements.GetLength(1))
                {
                    throw new IndexOutOfRangeException("Index  is invalid");
                }

                this.elements[row, col] = value;
            }
        }


        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            Matrix<T> newMatrix = new Matrix<T>();
            for (int i = 0; i < newMatrix.elements.GetLength(0); i++)
            {
                for (int j = 0; j < newMatrix.elements.GetLength(1); j++)
                {
                    try
                    {
                        newMatrix.elements[i, j] = (dynamic)first.elements[i, j] + (dynamic)second.elements[i, j];
                    }
                    catch (Exception)
                    {
                        throw new Exception("The members of the matrix must be numbers");
                    }
                }
            }
            return newMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            Matrix<T> newMatrix = new Matrix<T>();
            for (int i = 0; i < newMatrix.elements.GetLength(0); i++)
            {
                for (int j = 0; j < newMatrix.elements.GetLength(1); j++)
                {
                    try
                    {
                        newMatrix.elements[i, j] = (dynamic)first.elements[i, j] - (dynamic)second.elements[i, j];
                    }
                    catch (Exception)
                    {
                        throw new Exception("The members of the matrix must be numbers");
                    }
                }
            }
            return newMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            Matrix<T> newMatrix = new Matrix<T>();
            newMatrix.elements = new T[first.elements.GetLength(0), second.elements.GetLength(1)];
            if (first.elements.GetLength(1) != second.elements.GetLength(0))
            {
                throw new Exception("The columns in first matrix must be equal to rows in second!");
            }
            for (int i = 0; i < newMatrix.elements.GetLength(0); i++)
            {
                for (int j = 0; j < newMatrix.elements.GetLength(1); j++)
                {
                    for (int k = 0; k < first.elements.GetLength(1); k++)
                    {
                        try
                        {
                            newMatrix.elements[i, j] = (dynamic)newMatrix.elements[i, j] + (dynamic)first.elements[i, k] * (dynamic)second.elements[k, j];
                        }

                        catch (Exception)
                        {
                            throw new Exception("The members of the matrix must be numbers");
                        }
                    }
                }
            }
            return newMatrix;
        }

        public static bool operator true(Matrix<T> first)
        {
            for (int i = 0; i < first.elements.GetLength(0); i++)
            {
                for (int j = 0; j < first.elements.GetLength(1); j++)
                {
                    if ((dynamic)first.elements[i,j]==0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator false(Matrix<T> first)
        {
            for (int i = 0; i < first.elements.GetLength(0); i++)
            {
                for (int j = 0; j < first.elements.GetLength(1); j++)
                {
                    if ((dynamic)first.elements[i, j] != 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
