using FluentResults;

// https://github.com/altmann/FluentResults

var successResult1 = Result.Ok();

// create a result which indicates failure
var errorResult1 = Result.Fail("My error message");
var errorResult2 = Result.Fail(new Error("My error message"));
var errorResult4 = Result.Fail(new List<string> { "Error 1", "Error 2" });
var errorResult5 = Result.Fail(new List<IError> { new Error("Error 1"), new Error("Error 2") });