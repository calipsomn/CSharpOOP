﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    public class Matrix<T> where T : struct, IComparable, IFormattable, IConvertible,
                                IComparable<T>, IEquatable<T>
    {
        private T[,] elements;
        private int rows = 0;
        private int columns = 0;

        public int Rows
        {
            get { return rows; }
            set { rows = value; }
        }

        public int Columns
        {
            get { return columns; }
            set { columns = value; }
        }

        public T this[int row, int col]
        {
            get
            {
                return elements[row, col];
            }
            set
            {
                this.elements[row, col] = value;
            }
        }

        public Matrix(int rowCount, int colCount)
        {
            this.elements = new T[rowCount, colCount];
            this.rows = rowCount;
            this.columns = colCount;
        }

        public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            var rowsCount = matrix1.Rows;
            var columnsCount = matrix1.Columns;
            if (rowsCount != matrix2.Rows || columnsCount != matrix2.Columns)
            {
                throw new ArithmeticException("The two matricies must have the same number of rows and columns");
            }

            Matrix<T> result = new Matrix<T>(rowsCount, columnsCount);
            for (int rowInd = 0; rowInd < rowsCount; rowInd++)
            {
                for (int colInd = 0; colInd < columnsCount; colInd++)
                {
                    //result[rowInd, colInd] = matrix1[rowInd, colInd] + matrix2[rowInd, colInd];
                }
            }
            return result;
        }
    }
}
