# Unexpected Behavior with Mutable Variables in F#

This repository demonstrates a common pitfall in F#: unexpected behavior when using mutable variables within functions.  Mutable variables are not automatically updated in F# when their values change.  This example shows how this can lead to unexpected results, especially when values are assigned based on mutable variable values.

## How to Reproduce

1. Clone this repository.
2. Open the `bug.fs` file.
3. Run the code. Observe that the second `printfn` call displays the same value for `y` even though `x` has been updated. 
4. Open the `bugSolution.fs` file for a solution which will address this issue.

## Solution

The solution involves understanding that changes to mutable variables only affect the variable itself. If you need a value to reflect the changes made to a mutable variable after its initial assignment, consider re-assignment.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.