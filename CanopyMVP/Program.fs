open System
open canopy
open PageObjects.DemoQA_homePage

start chrome

"TEST: Register new user on demoQA" &&& fun _ ->
    PageObjects.DemoQA_homePage.openHomePage()
    PageObjects.DemoQA_homePage.clickRegistrationButton()

//run all tests
run()

printfn "press [enter] to exit"
System.Console.ReadLine() |> ignore

quit()