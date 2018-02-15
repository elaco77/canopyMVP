namespace PageObjects

module DemoQA_homePage =
    open canopy

    let openHomePage() = 
        url "http://demoqa.com"

    let clickRegistrationButton() =
        click "#menu-item-374"