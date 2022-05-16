# RustSeeSharp

Proof of concept on integrating Rust in C# applications for smaller, faster and memory safer operations

## What's what?

"Rusted Sea" (rusted_sea) is an example project in Rust, that provides some example operations.
"Sharp See" (SharpSea) is the same implementation in C# to compare CPU and memory usage.
"See Shark" (SeeShark) is a console application in C# on top of it, providing high level interface and benchmarks for operations.
"Tests" (SeeShark.Tests) are, as name suggests, tests for C# project - making sure outputs from Rust functions are the same.

## Report

This is the main course of this exercise - conslusions about drawbacks, advantages and issues.

### Drawback 1: no code contract

"SeeShark" is using "rusted_sea" as a DLL, but there are basically two implemations of the same thing.
Mistake in name or type in C# will make it almost impossible to maintain projects.

### Drawback 2: double the tests

To circumvent the issues with code contracts and importing C-style unmanaged DLLs into managed .NET, I'm testing the same thing twice.
