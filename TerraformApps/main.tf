terraform {
    required_providers {
        azurerm = {
            source  = "hashicorp/azurerm"
            version = "~> 2.46.0"
        }    
    }    
}

provider "azurerm" {
    features {}
}

resource "azurerm_resource_group" "main" {
    # creating a resource group named "Nsama-project2"
    name     = "Nsama-project2"
    location = "uksouth"
}
resource "azurerm_app_service_plan" "example" {
  name                = "Nsama-appserviceplan"
  location            = azurerm_resource_group.main.location
  resource_group_name = azurerm_resource_group.main.name

  sku {
    tier = "Free"
    size = "F1"
  }
}

resource "azurerm_app_service" "example" {
  name                = "Nsama-Frontend-App"
  location            = azurerm_resource_group.main.location
  resource_group_name = azurerm_resource_group.main.name
  app_service_plan_id = azurerm_app_service_plan.example.id
  


}

resource "azurerm_app_service" "anime" {
  name                = "Nsama-Anime-App"
  location            = azurerm_resource_group.main.location
  resource_group_name = azurerm_resource_group.main.name
  app_service_plan_id = azurerm_app_service_plan.example.id
  


}
resource "azurerm_app_service" "manga" {
  name                = "Nsama-Manga-App"
  location            = azurerm_resource_group.main.location
  resource_group_name = azurerm_resource_group.main.name
  app_service_plan_id = azurerm_app_service_plan.example.id
  


}
resource "azurerm_app_service" "merge" {
  name                = "Nsama-Merge-App"
  location            = azurerm_resource_group.main.location
  resource_group_name = azurerm_resource_group.main.name
  app_service_plan_id = azurerm_app_service_plan.example.id
  


}
