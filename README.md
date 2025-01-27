# F# Mutable Variable Bug

This repository demonstrates a common error in F# involving mutable variables and unexpected behavior in a simple addition function. The function `add` does not modify the input variables.  The example shows how to correctly use mutable variables and explains how to avoid this issue in the future.

## Bug Description
The bug arises from a misunderstanding of F#'s immutability. Mutable variables, while allowed, can lead to unexpected behavior if not carefully managed. The `add` function, despite using mutable inputs, does not update their values.  The original values are used in the sum calculation.

## Solution
The solution demonstrates how to either correctly use mutable variables to modify their values within the function, or a better approach of using immutable values and returning a new result.

## How to Reproduce
1. Clone the repository.
2. Open the `bug.fs` file to see the code that produces the unexpected behavior. 
3. Run `bug.fs` and observe the output. It shows the sum of the initial values of `x` and `y` (30), not the values after the `add` function which does not change the values. 
4. Open `bugSolution.fs` to see the corrected code which implements a function that changes the values. 
5. Run the file `bugSolution.fs` to observe the corrected output. 