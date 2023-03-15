
var filter = new CrateFilters.UnlockableAndNotRedactedCrateFilter()
                 .Cast<ICrateFilter<Crate>>();
var propCrates =
    AssetWarehouseExtensions.Filter(AssetWarehouse.Instance.GetCrates(), filter)
        .ToArray()
        .Where(crate => crate.Tags.Contains("Prop"))
        .ToArray();
foreach (var crate in propCrates)
  Log($"{crate.Title} = {crate.Barcode.ID}");

/*
Alarm Clock = SLZ.BONELAB.Content.Spawnable.AlarmClock
Apollo Giant = SLZ.BONELAB.Content.Spawnable.ApolloGiant
Apollo Gold = SLZ.BONELAB.Content.Spawnable.ApolloGold
Apollo = c1534c5a-f938-40cb-8be5-23db41706f6c
Barrel Metal A = SLZ.BONELAB.Content.Spawnable.Barrel2
Barrel Metal B = SLZ.BONELAB.Content.Spawnable.BarrelMetalB
Barrel Plastic A = SLZ.BONELAB.Content.Spawnable.BarrelPlasticA
Barrel Plastic B = SLZ.BONELAB.Content.Spawnable.BarrelPlasticB
Barrel Plastic C = SLZ.BONELAB.Content.Spawnable.BarrelPlasticC
Barrel Wooden = SLZ.BONELAB.Content.Spawnable.DestructibleBarrel
Baseball = c1534c5a-837c-43ca-b4b5-33d842617365
Basketball = c1534c5a-0c71-4ce9-a9bb-af8a50726f70
Bench Concrete Long = SLZ.BONELAB.Content.Spawnable.ConcreteBenchLong
Bench Concrete Short = SLZ.BONELAB.Content.Spawnable.ConcreteBenchShort
Bench Fancy = SLZ.BONELAB.Content.Spawnable.BenchFancy
Bench Wooden A = SLZ.BONELAB.Content.Spawnable.WoodBench
Bench Wooden B = SLZ.BONELAB.Content.Spawnable.BenchWoodenB
Billboard A = SLZ.BONELAB.Content.Spawnable.BillboardA
Billboard B = SLZ.BONELAB.Content.Spawnable.BillboardB
Billboard C = SLZ.BONELAB.Content.Spawnable.BillboardC
Billboard D = SLZ.BONELAB.Content.Spawnable.BillboardD
Billboard E = SLZ.BONELAB.Content.Spawnable.BillboardE
Billboard F = SLZ.BONELAB.Content.Spawnable.BillboardF
Book A = SLZ.BONELAB.Content.Spawnable.BookA
Book B = SLZ.BONELAB.Content.Spawnable.BookB
Book C = SLZ.BONELAB.Content.Spawnable.BookC
Bottle Melon = SLZ.BONELAB.Content.Spawnable.BottleMelon
Bottle Pill = SLZ.BONELAB.Content.Spawnable.BottlePill
Bottle UM = SLZ.BONELAB.Content.Spawnable.BottleUM
Bowling Ball Big = fa534c5a83ee4ec6bd641fec424c4142.Spawnable.PropBowlingBallBig
Bowling Ball = SLZ.BONELAB.Content.Spawnable.BowlingBall
Bowling Pin Big = SLZ.BONELAB.Content.Spawnable.BowlingPinBig
Bowling Pin = SLZ.BONELAB.Content.Spawnable.BowlingPin
Brick = c1534c5a-6f93-4d58-b9a9-ca1c50726f70
Broom = SLZ.BONELAB.Content.Spawnable.Propbroom
Bucket Metal = SLZ.BONELAB.Content.Spawnable.MopBucket
Bucket Wooden = SLZ.BONELAB.Content.Spawnable.Bucket
Bush Standee A = SLZ.BONELAB.Content.Spawnable.BushCutout1
Bush Standee B = SLZ.BONELAB.Content.Spawnable.BushStandeeB
Bush Standee C = SLZ.BONELAB.Content.Spawnable.BushStandeeC
Cafe Tray = SLZ.BONELAB.Content.Spawnable.CafeTray
Cardboard Box Crablet = SLZ.BONELAB.Content.Spawnable.CardboardBoxCrablet
Cardboard Box Monogon = c1534c5a-f974-4581-b812-9c9543617264
Cardboard Box = fa534c5a83ee4ec6bd641fec424c4142.Spawnable.DestcardboardBox
Cargo Pallet = SLZ.BONELAB.Content.Spawnable.CargoPallet
Cave Boulder A = SLZ.BONELAB.Content.Spawnable.CaveBoulder3Dynamic
Cave Boulder B = SLZ.BONELAB.Content.Spawnable.CaveBoulderB
Cave Boulder C = SLZ.BONELAB.Content.Spawnable.CaveBoulderC
Cave Small Rock = SLZ.BONELAB.Content.Spawnable.CaveSmallRock
Chair Bougie = SLZ.BONELAB.Content.Spawnable.ChairBougie
Chair Cafe = SLZ.BONELAB.Content.Spawnable.CafeChair
Chair Camping = SLZ.BONELAB.Content.Spawnable.ChairLawnchair
Chair Outdoor = SLZ.BONELAB.Content.Spawnable.ChairOutdoor
Chair Wooden A = SLZ.BONELAB.Content.Spawnable.ChairWoodenA
Chair Wooden B = SLZ.BONELAB.Content.Spawnable.WoodChairB
Cinder Block = SLZ.BONELAB.Content.Spawnable.CinderBlock
Clay Bowl = SLZ.BONELAB.Content.Spawnable.ClayBowl
Clay Cup = SLZ.BONELAB.Content.Spawnable.ClayCup
Clay Plate = SLZ.BONELAB.Content.Spawnable.ClayPlate
Clay Pot A = SLZ.BONELAB.Content.Spawnable.ClayPotA
Clay Pot B = SLZ.BONELAB.Content.Spawnable.ClayPotB
Clay Pot C = SLZ.BONELAB.Content.Spawnable.ClayPotC
Clay Pot D = SLZ.BONELAB.Content.Spawnable.ClayPotD
Clay Pot E = SLZ.BONELAB.Content.Spawnable.ClayPotE
Clay Pot Large = SLZ.BONELAB.Content.Spawnable.ClayPotLarge
Clay Vase = SLZ.BONELAB.Content.Spawnable.ClayVase
Coffee Cup = c1534c5a-9629-4660-8439-186b50726f70
Concrete Barrier = c1534c5a-c29c-4343-8809-5f07436f6e63
Couch 1 Seat = SLZ.BONELAB.Content.Spawnable.Couch1Seat
Couch 2 Seat = SLZ.BONELAB.Content.Spawnable.Couch2Seat
Couch 3 Seat = SLZ.BONELAB.Content.Spawnable.Couch3Seat
Crate 1m Indestructible = c1534c5a-935a-44e8-8036-d86043726174
Crate 1m Wooden = c1534c5a-5be2-49d6-884e-d35c576f6f64
Crate 2m Indestructible = c1534c5a-450f-4fcd-95cf-887043726174
Desk Rolling Tall = SLZ.BONELAB.Content.Spawnable.DeskRollingTall
Desk Rolling = SLZ.BONELAB.Content.Spawnable.DeskRolling
Desk Table = SLZ.BONELAB.Content.Spawnable.Table01
Die D10 = SLZ.BONELAB.Content.Spawnable.DieD10
Die D12 = SLZ.BONELAB.Content.Spawnable.DieD12
Die D20 = SLZ.BONELAB.Content.Spawnable.Died20
Die D4 = SLZ.BONELAB.Content.Spawnable.DieD4
Die D6 = SLZ.BONELAB.Content.Spawnable.DieD6
Die D8 = SLZ.BONELAB.Content.Spawnable.DieD8
Donut Box = SLZ.BONELAB.Content.Spawnable.DonutBox
Dungeon Large Brick = SLZ.BONELAB.Content.Spawnable.DungeonLargeBrick
Dungeon Small Brick = SLZ.BONELAB.Content.Spawnable.DungeonSmallBrick
Figurine = SLZ.BONELAB.Content.Spawnable.Figurine
Flashlight = c1534c5a-38df-474e-abb3-7e81466c6173
Glowstick = c1534c5a-48ab-4117-94d0-20e0476c6f77
Gym Arch = c1534c5a-df6a-4c22-8317-44fd47796d41
Gym Beam = c1534c5a-1da1-47fa-accc-95ed47796d42
Gym Block A = c1534c5a-d80e-4a91-8081-ba1950726f70
Gym Block B = c1534c5a-a419-426e-96d9-e12e50726f70
Gym Block C = c1534c5a-2995-44a8-8e86-155150726f70
Gym Block D = c1534c5a-a460-47db-b01e-505c50726f70
Gym Block E = c1534c5a-ef31-491b-bb58-4d6950726f70
Gym Cone A = c1534c5a-067e-4466-9122-19c247796d43
Gym Cone B = c1534c5a-e510-4c7d-92fb-73d647796d43
Gym Cube 1x1 = c1534c5a-5c6f-473b-b20e-c8f447796d43
Gym Cube 2x2 = c1534c5a-5b13-4a6c-8d86-cf0547796d43
Gym Cube 3x3 = c1534c5a-bf39-4abf-832a-461347796d43
Gym Cube Small = c1534c5a-86b1-4192-9785-2e0750726f70
Gym Cylinder Half A = c1534c5a-a7be-49a9-b6f2-bcbf47796d43
Gym Cylinder Half B = c1534c5a-fd7b-48c5-8fd7-e1d347796d43
Gym Cylinder Large A = c1534c5a-ac3b-42ea-a60c-5d5a47796d43
Gym Cylinder Large B = c1534c5a-4b47-4f36-9cdb-6ea147796d43
Gym Cylinder Small = c1534c5a-375f-4410-8bc6-1a2750726f70
Gym D10 = c1534c5a-ea32-4493-898e-1aab50726f70
Gym D12 = c1534c5a-e1e6-488b-a49e-e0b850726f70
Gym D20 = c1534c5a-3199-4102-91e2-8ac650726f70
Gym D4 = c1534c5a-2a2d-488a-824b-df5b50726f70
Gym D6 = c1534c5a-33a1-4b6d-9312-bd8650726f70
Gym D8 = c1534c5a-33a6-4807-b4ee-ff9350726f70
Gym Disc A = c1534c5a-783c-45a9-97ae-87cf47796d44
Gym Disc B = c1534c5a-4295-4778-8761-89dd47796d44
Gym Medicine Ball = c1534c5a-5d9f-4744-bc75-70f247796d4d
Gym Octogon = c1534c5a-1b8b-4e7c-a476-074547796d4f
Gym Prism = c1534c5a-1092-4da0-8736-3e2f47796d50
Gym Shallow Ramp = c1534c5a-2b71-4b6f-8089-a40247796d53
Gym Soccer Ball = c1534c5a-33f4-4b5b-bb3b-d91547796d53
Gym Tall Ramp = c1534c5a-25db-4ece-a5d5-c81747796d54
Gym Torus = c1534c5a-15dd-4084-bf64-9ab747796d54
Gym Trapazoid A = c1534c5a-bc25-4967-9101-1b4b50726f70
Gym Trapazoid B = c1534c5a-c72d-4d56-95b7-a26250726f70
Gym Trapazoid C = c1534c5a-dea1-42b4-b95f-6b6f50726f70
Gym Trapazoid D = c1534c5a-66b3-4a1c-ad8d-9f7a50726f70
Gym Trapazoid E = c1534c5a-060f-44b5-ac72-d88450726f70
Hexagonal Container = c1534c5a-3ac8-4f19-913b-6bd348657861
Hitching Post = SLZ.BONELAB.Content.Spawnable.HitchingPost
Holo Panel = SLZ.BONELAB.Content.Spawnable.HoloPanel
Milk Crate = SLZ.BONELAB.Content.Spawnable.MilkCrate
Mirror = c1534c5a-8fc2-4596-b868-a7644d697272
Monkey = c1534c5a-202f-43f8-9a6c-1e9450726f70
Museum Statue = SLZ.BONELAB.Content.Spawnable.MuseumStatue
Origin Crate = SLZ.BONELAB.Content.Spawnable.OriginCrate
PC Keyboard B = SLZ.BONELAB.Content.Spawnable.PCKeyboardB
PC Keyboard = SLZ.BONELAB.Content.Spawnable.Keyboard
PC Monitor A = c1534c5a-4ca8-448c-80e1-882e4d6f6e69
PC Monitor B = SLZ.BONELAB.Content.Spawnable.PCMonitorB
PC Monitor C = SLZ.BONELAB.Content.Spawnable.PCMonitorC
PC Mouse = SLZ.BONELAB.Content.Spawnable.Mouse
PC Tower = SLZ.BONELAB.Content.Spawnable.PC
Pill = SLZ.BONELAB.Content.Spawnable.Pill
Pizzabox = SLZ.BONELAB.Content.Spawnable.Pizzabox
Plant Large = SLZ.BONELAB.Content.Spawnable.PlantLarge
Plant = c1534c5a-aeee-4983-8239-fe6144657374
Plunger = fa534c5a83ee4ec6bd641fec424c4142.Spawnable.Plunger
Plywood A = SLZ.BONELAB.Content.Spawnable.PlywoodA
Plywood B = SLZ.BONELAB.Content.Spawnable.PlywoodB
Plywood C = SLZ.BONELAB.Content.Spawnable.PlywoodC
Plywood D = SLZ.BONELAB.Content.Spawnable.PlywoodD
Plywood E = SLZ.BONELAB.Content.Spawnable.PlywoodE
Plywood G = SLZ.BONELAB.Content.Spawnable.PlywoodG
Portable Ramp = SLZ.BONELAB.Content.Spawnable.PortableRamp
Portable Stairs = SLZ.BONELAB.Content.Spawnable.PortableStairs
Pressure Tank Mini = SLZ.BONELAB.Content.Spawnable.PressureTankMini
Pressure Tank = SLZ.BONELAB.Content.Spawnable.PressureTank
Printer = SLZ.BONELAB.Content.Spawnable.Printer
Roll Ball 100kg = fa534c5a83ee4ec6bd641fec424c4142.Spawnable.PropRollBall100kg
Scaffolding A = SLZ.BONELAB.Content.Spawnable.PropScaffolding
Scaffolding B = SLZ.BONELAB.Content.Spawnable.ScaffoldingB
Scaffolding C = SLZ.BONELAB.Content.Spawnable.ScaffoldingC
Shelf Metal = SLZ.BONELAB.Content.Spawnable.MetalShelf
Shelf Wooden Small = SLZ.BONELAB.Content.Spawnable.ShelfWoodenSmall
Shelf Wooden Tall = SLZ.BONELAB.Content.Spawnable.ShelfWoodenTall
Shopping Cart = c1534c5a-6a57-477d-8bcd-e2dc53686f70
Skeleton Skull = SLZ.BONELAB.Content.Spawnable.SkeletonSkull
Soda Can B = SLZ.BONELAB.Content.Spawnable.SodaCanB
Soup Can = c1534c5a-9346-4ab8-a37d-698b536f7570
Stanford Bunny = SLZ.BONELAB.Content.Spawnable.StanfordBunny
Stool Wooden = SLZ.BONELAB.Content.Spawnable.SmallChair2
Sword Noodledog = c1534c5a-a1c4-4c90-ad5d-ea1a53776f72
Table Aluminum A = SLZ.BONELAB.Content.Spawnable.AluminumTable
Table Aluminum B = SLZ.BONELAB.Content.Spawnable.AluminumTableB
Table Decorative = SLZ.BONELAB.Content.Spawnable.TableDecorative
Table Long = SLZ.BONELAB.Content.Spawnable.MeetingRoomTable
Table Low = SLZ.BONELAB.Content.Spawnable.CoffeeTable
Table Round Large = SLZ.BONELAB.Content.Spawnable.TableRound
Table Round Small = SLZ.BONELAB.Content.Spawnable.TableSideRound
Table Wooden A = SLZ.BONELAB.Content.Spawnable.TableWoodenA
Table Wooden B = SLZ.BONELAB.Content.Spawnable.TableWoodenB
Tactical Obstacle = SLZ.BONELAB.Content.Spawnable.RangeObstacle
Tactical Target = SLZ.BONELAB.Content.Spawnable.TacticalTarget
Target Ghost = SLZ.BONELAB.Content.Spawnable.TargetGhost
Target Rat = SLZ.BONELAB.Content.Spawnable.TargetRat
Teapot = SLZ.BONELAB.Content.Spawnable.Teapot
Television Portable = SLZ.BONELAB.Content.Spawnable.TelevisionPortable
Television = SLZ.BONELAB.Content.Spawnable.PropTelevision
Time Couch = SLZ.BONELAB.Content.Spawnable.TimeCouch
Toolbox = SLZ.BONELAB.Content.Spawnable.Toolbox
Toy Lunar Lander = SLZ.BONELAB.Content.Spawnable.ToyLunarLander
Traffic Cone Toon = SLZ.BONELAB.Content.Spawnable.TrafficConeToon
Traffic Cone = SLZ.BONELAB.Content.Spawnable.TrafficCone
Trashbag A = SLZ.BONELAB.Content.Spawnable.Trashbag01
Trashbag B = SLZ.BONELAB.Content.Spawnable.Trashbag02
Trashcan Metal = SLZ.BONELAB.Content.Spawnable.TrashcanA
Trashcan Office A = SLZ.BONELAB.Content.Spawnable.Trashcan
Trashcan Office B = SLZ.BONELAB.Content.Spawnable.TrashcanMetal
Trashcan Rubber = SLZ.BONELAB.Content.Spawnable.Trashcan01
Trough = SLZ.BONELAB.Content.Spawnable.Trough
Vending Machine A = SLZ.BONELAB.Content.Spawnable.VendingMachineUM
Vending Machine B = SLZ.BONELAB.Content.Spawnable.VendingMachineB
Vending Machine C = SLZ.BONELAB.Content.Spawnable.VendingMachineC
Washbucket = SLZ.BONELAB.Content.Spawnable.Washbucket
Watermelon = c1534c5a-1e43-4d94-a504-31d457617465
Weighted Cube = SLZ.BONELAB.Content.Spawnable.WeightedCube
Weighted Hook = SLZ.BONELAB.Content.Spawnable.WeightedHook
*/
