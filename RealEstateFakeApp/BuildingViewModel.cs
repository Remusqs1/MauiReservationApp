using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace RealEstateFakeApp
{
    public partial class BuildingViewModel: ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Building> buildingCollection;

        public BuildingViewModel()
        {
            buildingCollection = new ObservableCollection<Building>();
            buildingCollection.Add(new Building { Picture = "room2", Status = "Premium", StatusColor = Color.FromArgb("#ffa654"), Price = "$449,990", Description = "Exclusive, services, all bills included. City View", Beds = "2 beds", Bath = "2 baths", Sqfts = "150 sqfts", BuildingType = "Villa" });
            buildingCollection.Add(new Building { Picture = "room3", Status = "Featured", StatusColor = Color.FromArgb("#7bd944"), Price = "$449,990", Description = "Exclusive, services, all bills included. City View", Beds = "2 beds", Bath = "2 baths", Sqfts = "150 sqfts", BuildingType = "Villa" });
        }

    }
}

