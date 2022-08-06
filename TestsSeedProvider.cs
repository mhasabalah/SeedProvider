namespace Tests.Server;
public class TestsSeedProvider : BaseEntitySeedProvider
{
    public override List<ProductStructure> SeedProductStructure()
    {
        List<ProductStructure> domainSystemFeatures = new List<ProductStructure>
            {
                new ProductStructure
                {
                    Id = new Guid("ParentChildId"),
                    ParentId = new Guid(""),
                    Name = "الاسم",
                    NameSecondLanguage = "NameOfSecondLanguage",
                    Route = "Tests",
                    Icon = "fas fa-money-bill",
                    DisplayOrder = 3,
                    NodeType = NodeType.Domain,

                },
                new ProductStructure
                {
                    Id = new Guid("ChildId-1"),
                    ParentId = new Guid("ParentChildId"),
                    Name = SharedResource.ResourceManager.GetString("BrowseFeature", new CultureInfo("ar-EG")),
                    NameSecondLanguage =SharedResource.ResourceManager.GetString("BrowseFeature", new CultureInfo("en-US")),
                    Route = nameof(SystemFeatureType.Browse),
                    NodeType = NodeType.SubDomain,

                    SystemFeatureType = SystemFeatureType.Browse
                },
                new ProductStructure
                {
                    Id = new Guid("ChildId-2"),
                    ParentId = new Guid("ParentChildId"),
                    Name = SharedResource.ResourceManager.GetString("AddFeature", new CultureInfo("ar-EG")),
                    NameSecondLanguage =SharedResource.ResourceManager.GetString("AddFeature", new CultureInfo("en-US")),
                    Route = nameof(SystemFeatureType.Add),
                    NodeType = NodeType.SubDomain,

                    SystemFeatureType = SystemFeatureType.Add
                },
                new ProductStructure
                {
                    Id = new Guid("ChildId-3"),
                    ParentId = new Guid("ParentChildId"),
                    Name = SharedResource.ResourceManager.GetString("EditFeature", new CultureInfo("ar-EG")),
                    NameSecondLanguage =SharedResource.ResourceManager.GetString("EditFeature", new CultureInfo("en-US")),
                    Route = nameof(SystemFeatureType.Edit),
                    NodeType = NodeType.SubDomain,

                    SystemFeatureType = SystemFeatureType.Edit
                },
                new ProductStructure
                {
                    Id = new Guid("ChildId-4"),
                    ParentId = new Guid("ParentChildId"),
                    Name = SharedResource.ResourceManager.GetString("DetailsFeature", new CultureInfo("ar-EG")),
                    NameSecondLanguage =SharedResource.ResourceManager.GetString("DetailsFeature", new CultureInfo("en-US")),
                    Route = nameof(SystemFeatureType.Details),
                    NodeType = NodeType.SubDomain,

                    SystemFeatureType = SystemFeatureType.Details
                },
                new ProductStructure
                {
                    Id = new Guid("ChildId-5"),
                    ParentId = new Guid("ParentChildId"),
                    Name = SharedResource.ResourceManager.GetString("DeleteFeature", new CultureInfo("ar-EG")),
                    NameSecondLanguage =SharedResource.ResourceManager.GetString("DeleteFeature", new CultureInfo("en-US")),
                    Route = nameof(SystemFeatureType.Delete),
                    NodeType = NodeType.SubDomain,

                    SystemFeatureType = SystemFeatureType.Delete
                },
            };
        return domainSystemFeatures;
    }
}