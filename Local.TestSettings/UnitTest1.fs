module Local.TestSettings

open NUnit.Framework

[<SetUp>]
let Setup () =
    ()

[<Test>]
let Test1 () =
    Assert.Pass()
