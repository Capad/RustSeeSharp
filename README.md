# RustSeeSharp

Proof of concept on integrating Rust in C# applications for smaller, faster and memory safer operations

## What's what?

- "Rusted Sea" (rusted_sea) is an example project in Rust, that provides some example operations.
- "See Shark" (SeeShark) is a console application in C# on top of it, providing high level interface and benchmarks for operations.
- "Tests" (SeeShark.Tests) are, as name suggests, tests for C# project - making sure outputs from Rust functions are the same.

## Report

This is the main course of this exercise - conslusions about drawbacks, advantages and issues.

### Drawback 1: no code contract

"SeeShark" is using "rusted_sea" as a DLL, but there are basically two implemations of the same thing.
Mistake in name or type in C# will make it almost impossible to maintain projects.

### Drawback 2: double the tests

To circumvent the issues with code contracts and importing C-style unmanaged DLLs into managed .NET, I'm testing the same thing twice.

### Drawback 3: issues in tutorial

I was using "classic" tutorial from <https://dev.to/living_syn/calling-rust-from-c-6hk> and there were issues mentioned, like trouble with converting booleans, that did not really occure.

### Drawback 4: benchmarking Rust with dotnet tools

I'm using BenchmarkDotNet to measure performance of both imported Rust DLL and native C# code. It does not seem like a good idea, maybe I'll figure something out. Also, covering both static implementations with proper objects with default constructor seems a bit over the top.

### Drawback 5: direct calling for build

In order to mitigate issues with incorrect version, all projects calling for Rust DLLs are executing `cargo build` or `cargo build --release`, then copying DLL from Rust `target` folders to respective .NET `bin`folders, as it needs to be present in the same folder as executable.

### Concern 1: security

Seems relatively easy to attach malicious code inside one of Rust functions and execute unwanted process on target machine.

### Concern 2: building with Docker

For me, Rust programs are notoriously painful when I'm trying to build Docker images - adding on top of it dotnet calls for multistage build.
