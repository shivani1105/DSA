# C# Data Structures and Algorithms (DSA) Practice

## Overview

This repository showcases my journey in mastering Data Structures and Algorithms (DSA) using C#. It includes implementations of fundamental algorithms and solutions to common coding challenges, aimed at improving problem-solving skills and deepening my understanding of efficient data manipulation.

## Table of Contents

1. [Sorting Algorithms](#sorting-algorithms)
   - [Merge Sort](#merge-sort)
   - [Quick Sort](#quick-sort)
2. [Searching Algorithms](#searching-algorithms)
   - [Binary Search](#binary-search)
   - [Hash Search](#hash-search)
3. [String Manipulation](#string-manipulation)
   - [Longest Palindromic Substring](#longest-palindromic-substring)
4. [Array-Based Problems](#array-based-problems)
   - [Two Sum Solution](#two-sum-solution)

---

## Sorting Algorithms

### Merge Sort
- **Description**: Merge Sort is a divide-and-conquer algorithm that recursively splits the array into subarrays, sorts them, and merges them back in sorted order.
- **Complexity**: O(n log n)
- **File**: [Merge Sort](./MergeSortAlgo.cs)

### Quick Sort
- **Description**: Quick Sort is an efficient sorting algorithm that selects a pivot element, partitions the array, and recursively sorts the partitions.
- **Complexity**: Average O(n log n), Worst O(n²)
- **File**: [Quick Sort](./QuickSortAlgo.cs)

---

## Searching Algorithms

### Binary Search
- **Description**: Binary Search is a search algorithm that finds the position of a target value within a sorted array, reducing the search range by half each time.
- **Complexity**: O(log n)
- **File**: [Binary Search](./BinarySearchAlgo.cs)

### Hash Search
- **Description**: Hash Search uses hashing to quickly locate an element within a collection, ideal for unsorted data.
- **Complexity**: Average O(1) for search operations in well-distributed hash functions.
- **File**: [Hash Search](./Hasher.cs)

---

## String Manipulation

### Longest Palindromic Substring
- **Description**: Finds the longest substring within a given string that reads the same forward and backward.
- **Approach**: Expands around each character (center expansion).
- **Complexity**: O(n²)
- **File**: [Longest Palindromic Substring](./LongestPalindromicSubstring.cs)

---

## Array-Based Problems

### Two Sum Solution
- **Description**: Solves the two-sum problem by finding two numbers in an array that add up to a specific target.
- **Approach**: Uses a hash map to store elements and their indices for O(n) complexity.
- **Complexity**: O(n)
- **File**: [Two sum solution.cs](./TwoSumSolution.cs)
