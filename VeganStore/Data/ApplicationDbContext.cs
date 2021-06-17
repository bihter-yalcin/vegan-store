using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeganStore.Models;

namespace VeganStore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Comment> Comments { get;  set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Food" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "MakeUp" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Skincare" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Fragrance" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Hair" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 6, CategoryName = "Bath and Body" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 7, CategoryName = "Tools and Brushes" });


            //seed pies

            //Skincare

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                BrandName= "Empire Australia",
                ProductName = "Lemon Myrtle & Grapefruit Pure Hand Balm",
                Description = "Protect and Nourish",
                LongDescription= "Lemon Myrtle & Grapefruit Pure Hand Balm is rich in Shea Butter and pure, steam distilled essential oils. Melts beautifully into skin to protect and nourish.",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/f385d77b75c66beaf523e88931430faa1f8bece6_1400x.jpg?v=1597883424",
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/f385d77b75c66beaf523e88931430faa1f8bece6_1400x.jpg?v=1597883424",
                Price = 6.9M,
                Stock = 10,
                InStock = true,
                IsPopular = true,
                CategoryId =3
             }
              );



            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                BrandName = "Botanika Blends",
                ProductName = "Beauty Potion - Vegan Collagen Boost 300g",
                Description = "Collagen Production",
                LongDescription = "Botanika Blends beauty potion is a carefully crafted concoction using ingredients ideal for collagen production and general well-being. Collagen plays a vital role in your bodies tissue such as hair, skin, nails, muscles plus many other areas. We use key plant based amino acids, natural sources of vitamin c, antioxidant rich fruit powders, probiotics, vitamins & minerals amongst other goodies to achieve what a beauty potion should be all about... beauty from within (you are what you drink, bottoms up!) Typically, collagen supplements are derived from animal sources such as beef and fish however our Beauty Potion is completely vegan friendly containing no animal sourced ingredients. 300g. Ingredients: Superfruit Juice Powder (Raspberry, Strawberry, Pomegranate, Elderberry, Blackcurrant, Blueberry, Cranberry, Acai, Goji), L-Glutamine, L-Glycine, L-Proline, Natural Flavour, L-Lysine, Baobab Fruit Powder Organic, Probiotic Culture (Bacillus Coagulans), Anticaking Agent (Silicon Dioxide), Organic Camu Camu Fruit Powder, Minerals (Dipotassium Phosphate, Tricalcium Phosphate, Magnesium Oxide, Ferric Pyrophosphate, Zinc Sulphate Monohydrate, Sodium Selenite, Chromium Chloride, Copper Sulphate, Manganese Sulphate, Potassium Iodide, Sodium Molybdate), Vitamins E, C, A, B1, B (Vitamins & Minerals Premix), Aloe Vera Powder, Organic Maca Powder, Green Tea Extract, Natural Sweetener (Stevia), Beetroot Powder. Vegan.",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/8ead22ec10a148f6e239a612e94ab6ed45521ffd_1400x.jpg?v=1561762814",
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/8ead22ec10a148f6e239a612e94ab6ed45521ffd_1400x.jpg?v=1561762814",
                Price = 54.95M,
                Stock = 10,
                InStock = true,
                IsPopular = false,
                CategoryId = 3
            }
            );



            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                BrandName = "Andalou",
                ProductName = "Quenching Coconut Water Firming Toner",
                Description = "Facial Refresher",
                LongDescription = "This instant facial refresher hydrates, fortifies, and balances, improving the appearance of tone and texture with skin-friendly enzymes, vitamin C, and coconut water electrolytes for a healthy, smooth complexion. AquaCacteen, derived from prickly pear cactus, nourishes and soothes as water-binding nutrients provide lasting hydration for a lifted, firmer appearance and renewed vitality. ECOCERT certified To Use: Shake well. After cleansing, close eyes, gently mist face and neck to best prepare skin for moisturizing. For skin soothing hydration day and night, mist lightly with or without make-up. For Parched/Depleted Skin Resveratrol and CoQlO, super-antioxidants support collagen and elastin, the skin's essential building blocks, while an abundance of plant omegas deeply nourish for a more lifted, firmer appearance and a fresh, rejuvenated complexion. 178ml. Ingredients: Aloe Barbadensis Leaf Juice*, Purified Water (Aqua), Cocos Nucifera (Coconut) Water*†, Vegetable Glycerin, Panthenol, Sodium PCA, Tocopherol, Sorbitan Oleate Decylglucoside, Opuntia Ficus-Indica (Prickly Pear) Stem Extract*, Fruit Stem Cells (Malus Domestica, Solar Vitis) and BioActive Berry Complex*, Magnesium Ascorbyl Phosphate (Vitamin C), Skin Firming Complex: [Cichorium Intybus (Chicory) Root Oligosaccharides, Caesalpinia Spinosa (Tara Tree) Gum, Coffea Arabica (Green Coffee) Extract*], Opuntia Ficus-Indica (Prickly Pear) Seed Oil*, Camellia Sinensis (White Tea) Leaf Extract*†, Aspalathus Linearis (Rooibos) Extract*†, Phenethyl Alcohol, Ethylhexylglycerin, Coconut Isolates, Citrus Aurantifolia (Lime) Peel Oil*, Mentha Spicata (Spearmint) Leaf Oil* *Certified Organic Ingredients †Fair Trade Ingredients Vegan. Certified cruelty-free by Leaping Bunny. Gluten-free, GMO-free.",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/12ddf81b8d1a4beebb8afc6b03f47df4bdf6ce72_1400x.png?v=1560988726",
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/12ddf81b8d1a4beebb8afc6b03f47df4bdf6ce72_1400x.png?v=1560988726",
                Price = 19.95M,
                Stock = 10,
                InStock = true,
                IsPopular = false,
                CategoryId = 3
            }
            );

            //Makeup 


            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 6,
                BrandName = "Benecos",
                ProductName = "Eyeshadow Quattro - Coffee & Cream",
                Description = "Perfect Smokey Eye",
                LongDescription = "Use these glamorous shades to dazzle during the day then layer up for a night out with the girls. Our Quattro sets are made up of 4 perfectly coordinated tones for creating the perfect smokey eye or use individually for beautifully bold eyes. Benefits are 1-Certified BDIH 2-Natural Suitable for vegans 3-Enriched with natural oils for smooth regenerated skin 4-Long lasting colour",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/0e58e1142c474d228b38e08c5e5ea8d47d076dfe_1400x.png?v=1596927231",
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/0e58e1142c474d228b38e08c5e5ea8d47d076dfe_1400x.png?v=1596927231",
                Price = 18.99M,
                Stock = 10,
                InStock = true,
                IsPopular = true,
                CategoryId = 2
            }
  );

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 7,
                BrandName = "Benecos",
                ProductName = "Vegan Magic Black Volume Mascara",
                Description = "Perfect Lift and Volume",
                LongDescription = "This vegan mascara enhances volume and creates an irresistible curve to your lashes. The natural formula creates smooth clump free application and the Vitamin E nourishes and cares for your lashes while providing perfect lift and volume Benefits Certified BDIH Natural Suitable for vegans No clumping Enriched with nourishing Vitamin E Layer for a more intense look Creates incredible volume and definition Highly pigmented How to use Apply with a zig-zag motion, one coat for natural volume or repeat for extra volume",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/106e6cb0a5ecb87dab1d91f708578829c803562a_1400x.png?v=1594889735",
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/106e6cb0a5ecb87dab1d91f708578829c803562a_1400x.png?v=1594889735",
                Price = 18.99M,
                Stock = 10,
                InStock = true,
                IsPopular = true,
                CategoryId = 2
            }
            );

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 8,
                BrandName = "Cruelty Free FACE",
                ProductName = "Lipstick - Very Berry (LS48)",
                Description = "Long-lasting and Moisturising",
                LongDescription = "Our Cruelty Free Face lipsticks will make you look good and feel even better, knowing that no animals were used or harmed in making these products. Made of 100% natural ingredients, our mineral lipsticks are long-lasting and moisturising and will leave your lips feeling luscious. Vegan, cruelty free and made in Australia. Colour: Very Berry Ingredients: Castor Seed Oil, Jojoba Seed Oil, Mica (CI 77019), CarnaubWax, Candelilla Wax, Shea Butter, Orange Peel Oil, Tocopherol, may contain (+/-) Tin Oxide (CI 778161), Titanium Dioxide (CI 77891), Iron Oxides (CI 77491, CI 77492, CI 77499), Ultramarines (CI 77007), Pigment Violet (CI 77742).",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/very_berry_1400x.JPG?v=1529217144",
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/very_berry_1400x.JPG?v=1529217144",
                Price = 24.95M,
                Stock = 10,
                InStock = true,
                IsPopular = false,
                CategoryId = 2
            }
            );

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 9,
                BrandName = "Cruelty Free FACE",
                ProductName = "Liquid Foundation - Porcelain (5)",
                Description = "Excellent Coverage",
                LongDescription = "Liquid mineral foundation is creamy, easy to apply, long lasting and has excellent coverage. SPF15. Colour: Porcelain (5). NB Please chose carefully, we are not able to refund cosmetics for health & safety reasons. 30g. Ingredients: Rose Flower Distillate, Water, Caprylic/Capric Triglyceride, Zinc Oxide, Mica (CI 77019), Glycerine, Cetearyl Glucoside (from coconut oil), Cetearyl Alcohol (from coconut oil), Magnesium Aluminim Silicate, Grapefruit Seed Extract, Xanthan Gum, may contain (+/-) Titanium Dioxide (CI 77891), Iron Oxides (CI 77491, CI 77492, CI 77499), Ultramarines (CI 77007). Vegan. Certified cruelty-free by Choose Cruelty Free Australia. Made in Australia. Palm oil-free. NB. Colours shown on a computer screen may not match actual colours. Colours tend to appear darker than they actually are. Unfortunately, for hygiene reasons, we are not able to accept returns of opened cosmetics. ",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/IMG_3951_1400x.JPG?v=1563147959",
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/IMG_3951_1400x.JPG?v=1563147959",
                Price = 39.95M,
                Stock = 10,
                InStock = true,
                IsPopular = false,
                CategoryId = 2
            }
            );

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 10,
                BrandName = "Cruelty Free FACE",
                ProductName = "Pressed Powder Foundation Compact - Ivory (10)",
                Description = "Natural-looking",
                LongDescription = "Cruelty Free FACE Pressed Powder Foundation Compact with mirror and applicator sponge. Colour: Ivory (10) NB Please chose carefully, we are not able to refund cosmetics for health & safety reasons. Mineral Powder Foundation is the purest, most natural-looking form and type of foundation available. This exceptional powder can be applied dry for a lighter coverage or wet for a heavier complete coverage and full spectrum sunscreen (SPF15). Incredible oil control with no separate concealer or powder needed. Excellent coverage and dense pigments make it perfect for hiding skin conditions such as acne, rosacea and scarring with ease. Apply with provided sponge. Vegan. Certified cruelty-free by Choose Cruelty Free Australia. Made in Australia. Palm oil-free. 14g. Ingredients: Zinc Stearate, Zea Mays (Corn) Starch, Zinc Oxide, Ethyl Macadamiate, Jojoba Esters, Tocopherol (Vitamin E Natural), Lauroyl Lysine, Malic Acid, May Contain (+/-) Mica (CI 77019), 77492, CI 77499), Titanium Dioxide (CI 77891), Tin Oxide (CI 778161), Ultramarines (CI 77007)",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/Screen_Shot_2019-07-15_at_9.24.18_am_c3301b48-9fc3-4858-8214-09a121e2c60a_1400x.png?v=1611706266",
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/Screen_Shot_2019-07-15_at_9.24.18_am_c3301b48-9fc3-4858-8214-09a121e2c60a_1400x.png?v=1611706266",
                Price = 29.95M,
                Stock = 10,
                InStock = true,
                IsPopular = false, 
                CategoryId = 2
            }
            );


            //Fragrance

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 11,
                BrandName = "Noosa Basics",
                ProductName = "Deodorant Spray - Lemon Myrtle 100ml",
                Description = " Fresh All Day",
                LongDescription = "Formulated with natural ingredients, this non-aerosol deodorant spray effectively reduces underarm odour while keeping you feeling fresh all day.",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/cd6d344f2fb80fdebd4d4f0003fe177cf680fd06_1400x.jpg?v=1617067536",
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/cd6d344f2fb80fdebd4d4f0003fe177cf680fd06_1400x.jpg?v=1617067536",
                Price = 19.99M,
                Stock = 10,
                InStock = true,
                IsPopular = true,
                CategoryId = 4
            }
              );

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 12,
                BrandName = "Noosa Basics",
                ProductName = "Deodorant Tin - Coconut Vanilla 50g",
                Description = "Plastic-free Deodorant",
                LongDescription = "Noosa Basics deodorant paste in a tin is a great plastic-free answer to your traditional deodorant. Using only 6 pure ingredients, this is hand crafted using Bi-Carb and Tapioca Starch to absorb moisture and help kill the bacteria that causes odour. Made in Australia, 100% Natural, Vegan and Cruelty free. -100% Natural with Certified Organic Ingredients -Neutralises odour fast -Lasts all day whether in the office or working out -A deodorant paste that is invisible after application -Aluminium free, alcohol free, paraben free -Vegan and certified cruelty-free -Hand made in Australia in small batches",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/e774d537c8b6591e91912f8b72e20265bccbb7d0_1400x.jpg?v=1617066480",
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/e774d537c8b6591e91912f8b72e20265bccbb7d0_1400x.jpg?v=1617066480",
                Price = 15.10M,
                Stock = 10,
                InStock = true,
                IsPopular = true,
                CategoryId = 4
            }
            );

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 13,
                BrandName = "Noosa Basics",
                ProductName = "Stick Deodorant - Coconut",
                Description = "Truly Organic",
                LongDescription = "Truly organic, All-natural deodorant that really works! Organic Tapioca and Australian Kaolin Clay absorbs the moisture while allow you to sweat and release toxins. Baking soda instantly kills the bacteria that causes odour. Shea butter nourishes your skin and Organic Coconut oil is well known for its antibacterial properties. Formulated with easy to understand ingredients, effective at neutralising odours instantly and keeping you fresh all day! While our deodorant has antiperspirant qualities, we can't call it one because we never use aluminium or parabens -ingredients required to be labelled an 'antiperspirant'-, which have been linked to diseases like cancer and Alzheimer’s. If switching from an antiperspirant, give your body a couple weeks to cleanse out toxins and adjust to our aluminium-free formula. 60g. Ingredients: Organic Fair trade Shea Butter*, Virgin Coconut Oil*, Tapioca Starch*, Bi-Carb Soda*, Candelilla Wax, Australian Kaolin Clay, Vegetable Cetyl Alcohol - Palm Oil Free, Essential Oil Blend of Rosemary*, Eucalyptus*, Peppermint*, Tea Tree* and Rose Geranium. *Certified Organic Ingredients Vegan. Certified cruelty-free by Choose Cruelty Free Australia. Organic. Aluminium-free, paraben-free.",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/noosacoconutvanilla_1400x.jpg?v=1588722393",
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/noosacoconutvanilla_1400x.jpg?v=1588722393",
                Price = 18.33M,
                Stock = 10,
                InStock = true,
                IsPopular = false,
                CategoryId = 4
            }
            );

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 14,
                BrandName = "Ben & Anna",
                ProductName = "Plastic-free Deodorant - Persian Lime 60g",
                Description = "Reliable Protection Against Sweat",
                LongDescription = "Thanks to a combination of select natural ingredients, “NATRUE”-certified Ben & Anna Deodorants offer reliable protection against body odor and sweat. Scent - Persian Lime: All fresh ingredients and a scent of lime. With its bright green colors it doesn’t just look full of freshness. Definitely the best selling deodorant of our range. For men and women alike. The deodorant is wrapped in paper tubes made from recycled paper. It’s good for your skin and good for the environment! Certified natural cosmetics 100% vegan & cruelty free No aluminum Recyclable cardboard packaging Supports environmental organization One Earth – One Ocean Certified cruelty-free and vegan by the Vegan Society UK and PETA.",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/3de7bc403aaa761cf10479f2e8ca2a7cf1a64f10_1400x.png?v=1573100785",
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/3de7bc403aaa761cf10479f2e8ca2a7cf1a64f10_1400x.png?v=1573100785",
                Price = 17.95M,
                Stock = 10,
                InStock = true,
                IsPopular = false,
                CategoryId = 4
            }
            );

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 15,
                BrandName = "The Physic Garden",
                ProductName = "Deodorant Paste - Lemon Myrtle 60g",
                Description = "Lasts All Day",
                LongDescription = "Natural Deodorant Paste with Lemon Myrtle Because natural deodorants are free from nasty chemicals and toxic heavy metals, that means they don't work as well, right? Imagine a completely natural deodorant which is not only toxic chemical-free, but actually contains healing ingredients, and lasts all day with one application... Our Lemon Myrtle Deodorant is Naturopathically formulated with the deliciously uplifting scents of Lemon Myrtle, Rosemary & Tea Tree. One application is all you need to keep you odour-free and revitalised through your busy day. Easy to apply, rub a pearl-sized amount under arms each morning. How to use: To apply, scoop a pearl-sized amount and rub under arms each morning or after showering. Not recommended for use immediately after shaving. One tub of Deodorant will last approximately 2 months with once daily use. Lemon Myrtle Deodorant: All Natural Ingredients Plastic-Free Packaging Free from Aluminium, Parabens & Alcohol Naturopathically Formulated Contains Lemon Myrtle & Rosemary Handmade in Melbourne, Australia Vegan Certified Cruelty-Free (tested on humans, not animals) 60g. Ingredients: Olea Europaea (Olive) Oil, *Butyrospermum Parkii (Shea Butter), Sodium Bicarbonate, *Maranta Arundinacea (Arrowroot) Root Powder, Euphorbia Cerifera (Candelilla) Wax, *Calendula Officinalis (Calendula), Backhousia Citriodora (Lemon Myrtle) Oil, Rosmarinus Officinalis (Rosemary) Oil, Melaleuca Alternifolia (Tea Tree) Oil. (*Certified Organic Ingredient)",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/45453ce2039100b4d4c82051cf62269b48112393_1400x.png?v=1591170026",
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/45453ce2039100b4d4c82051cf62269b48112393_1400x.png?v=1591170026",
                Price = 15.40M,
                Stock = 10,
                InStock = true,
                IsPopular = false,
                CategoryId = 4
            }
            );


            //Hair



            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 18,
                BrandName = "Giovanni",
                ProductName = "Hair Styling Gel L.A. Hold 200ml",
                Description = "Style Your Hair",
                LongDescription = "This controlling gel takes hold to the extreme. Formulated to include extraordinary ingredients that grab on to style and hold on tight. With the strongest hair gel from our Eco Chic® Hair Care collection, you can stand firm in the spotlight.This styling gel will not dull, strip color, or damage your hair. It’s color-safe, paraben-free, and cruelty-free. Giovanni hair care…bridging the gap between natural and salon-quality.",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/16f2d0d4250cdc8e070318ca2be34b7d58e85890_1400x.jpg?v=1597914278",
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/16f2d0d4250cdc8e070318ca2be34b7d58e85890_1400x.jpg?v=1597914278",
                Price = 19.99M,
                Stock = 10,
                InStock = true,
                IsPopular = false,
                CategoryId = 5
            }
            );

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 19,
                BrandName = "Empire Australia",
                ProductName = "Aromapure Shampoo - Dry/Damaged 500ml",
                Description = "Cleanser for Damaged Hair",
                LongDescription = "Cedarwood and Lavender combine in this gentle cleanser to soothe and enhance parched and damaged hair. Australian botanicals of Paw Paw and Rosemary work in harmony with Bergamot and Vitamin E for revitalised, clean, healthy hair.",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/8a7eb318451a2fe9b5c06b415055485c84b85df9_1400x.jpg?v=1592521200",
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/8a7eb318451a2fe9b5c06b415055485c84b85df9_1400x.jpg?v=1592521200",
                Price = 12.95M,
                Stock = 10,
                InStock = true,
                IsPopular = false,
                CategoryId = 5
            }
            );

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 20,
                BrandName = "Ethique",
                ProductName = "Too Delicious Conditioner Bar - Super Hydrating 60g",
                Description = "Deeply Hydrating Hair Treatment",
                LongDescription = "A vegan conditioner bar ideal for those with very dry hair or a bit of Curl. This is a super conditioner so deeply hydrating and can also be used as a once a week hair treatment. With hemp oil, pink grapefruit and shea butter. Each bar weighs 60g and gives the same amount of washes equivalent to 5 bottles of liquid conditioner (depending on the length of your hair). Plastic-free container, no excess packaging 100% Soap free Perfect for very dry hair Equivalent to 5 bottles of liquid conditioner Sustainable and palm oil free Certified Cruelty Free & Vegan Pro tip: This solid conditioner will leave your shower floor a little slippery, so please be careful!",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/788f43c840477177867bd3a01c184bdb1f3b2cf2_1400x.jpg?v=1618959362",
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/788f43c840477177867bd3a01c184bdb1f3b2cf2_1400x.jpg?v=1618959362",
                Price = 26.50M,
                Stock = 10,
                InStock = true,
                IsPopular = false,
                CategoryId = 5
            }
            );


            //Bath and Body

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 21,
                BrandName = "The Physic Garden",
                ProductName = "Bath Soak - Relax 220g",
                Description = "Spa at Home",
                LongDescription = "Just like a relaxing day spa at home Relax into a warm, delicious bath and feel the stress of the day dissolve away. Epsom salt relaxes sore muscles & the heavenly scents of Rose, Passionflower & Geranium calm & soothe the spirit. Directions: Add 3 tablespoons to a warm bath and soak for up to 30 minutes to enjoy the therapeutic benefit. Can also be used as a foot soak. Add salts directly to bath or in a cloth bag to infuse. 220g. Ingredients: Sea Salt, Murray River Salt, Epsom Salt, Rose Petals*, Passionflower*, Geranium Essential oil (*Certified Organic Ingredient).",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/4721d58e32fd9b52d8e2b46917dcafa58b3ad597_1400x.jpg?v=1591170021",
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/4721d58e32fd9b52d8e2b46917dcafa58b3ad597_1400x.jpg?v=1591170021",
                Price = 17.47M,
                Stock = 10,
                InStock = true,
                IsPopular = true,
                CategoryId = 6
            }
  );

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 22,
                BrandName = "Empire Australia",
                ProductName = "Aromapure Body Wash - Bergamot, Mandarin & Lavender 500ml",
                Description = "Revitalising and Aromatic",
                LongDescription = "Bergamot, Mandarin and Lavender are a relaxing, calming and earthy blend of pure essential oils infused in a gently cleansing body wash. Delightful Australian botanicals complete this naturally revitalising and aromatic formula.",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/bdd8afff27a6ff601bea4d9cb527ff548f9b228c_1400x.jpg?v=1592520932",
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/bdd8afff27a6ff601bea4d9cb527ff548f9b228c_1400x.jpg?v=1592520932",
                Price = 12.95M,
                Stock = 10,
                InStock = true,
                IsPopular = true,
                CategoryId = 6
            }
            );

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 23,
                BrandName = "Benecos",
                ProductName = "Shower Gel - Pomegranate & Rose 200ml",
                Description = "Floral Aroma",
                LongDescription = "Pamper your skin with our luxurious smelling Natural Pomegranate and Rose Shower Gel. The floral aroma sooths your senses while the natural ingredients sooth your skin. Enriched with wild rose, skin feels moisturised and hydrated while pomegranate seed oil repairs and regenerates skin cells. Benefits Certified BDIH Natural Made with natural and organic ingredients Cleanses and moisturises the skin Doesn't strip the skin of natural oils Refreshing scent",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/0d2ed84730d11efe97088d55f734293e288b5d85_1400x.png?v=1594888651",
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/0d2ed84730d11efe97088d55f734293e288b5d85_1400x.png?v=1594888651",
                Price = 13.76M,
                Stock = 10,
                InStock = true,
                IsPopular = false,
                CategoryId = 6
            }
            );

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 24,
                BrandName = "Benecos",
                ProductName = "For Men Body Wash 3in1 200ml",
                Description = "Clean and Fresh Scent",
                LongDescription = "Multi-tasking made easy. Our Natural 3 in 1 Body wash for men cleanses the body, face and hair in one go. Bursting with natural and organic ingredients, skin is left feeling smooth and hydrated while hair is soft and nourished. Benefits Suitable for vegans Certified COSMOS Organic Made with natural and organic ingredients Suitable for all skin types Clean fresh scent Cleanses the skin without stripping away natural oils",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/bf2893c17b4ec52718d21d1fcf817b18dc253bc8_1400x.jpg?v=1594888784",
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/bf2893c17b4ec52718d21d1fcf817b18dc253bc8_1400x.jpg?v=1594888784",
                Price = 12.69M,
                Stock = 10,
                InStock = true,
                IsPopular = false,
                CategoryId = 6
            }
            );

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 25,
                BrandName = "Natio",
                ProductName = "Men's Spice Of Life Body Wash 210ml",
                Description = "Refresh and Deodorise the Body",
                LongDescription = "Spice up your life and your skin with this everyday cleansing gel designed to gently refresh and deodorise the body. Specially formulated for the needs of today's modern man, the energising cleanser is enriched with nourishing plant oils and extracts to revitalise skin without stripping natural moisture while aromatic essential oils of Patchouli, Pepper and Clove leave a lingering, masculine fragrance. 210ml. Ingredients: Water (Aqua), Ammonium Lauryl Sulfate, Cocamidopropyl Betaine, Cocamide DEA, Aloe Barbadensis Leaf Extract, Chamomilla Recutita (Matricaria) Flower Extract, Melia Azadirachta Seed Oil, Curcuma Longa (Turmeric) Root Extract, Hydrastis Canadensis (Golden Seal) Extract, Pelargonium Graveolens Flower Oil, Tocopheryl Acetate, Dipterocarpus Turbinatus (Gurjum Balsam) Oil, Lavandula Intermedia Oil Pogostemon Cablin Oil, Piper Nigrum (Pepper) Fruit Oil, Salvia Officinalis (Sage) Oil, Thuja Occidentalis Leaf Oil, Ocimum Basilicum (Basil) Oil, Eugenia Caryophyllus (Clove) Leaf Oil, Fragrance (Parfum), Citrus Aurantium Dulcis (Orange) Oil, Citrus Medica Limonum (Lemon) Peel Oil, Citrus Aurantium Bergamia (Bergamot) Fruit Oil, Styrax Benzoin Gum, Phenoxyethanol, Potassium Sorbate, Citric Acid, Caramel. Vegan. Cruelty-free. ",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/a93fd3d7f4abd6986fc4c5ffbbddc636f7ca28dc_1400x.jpg?v=1600642303",
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/a93fd3d7f4abd6986fc4c5ffbbddc636f7ca28dc_1400x.jpg?v=1600642303",
                Price = 11.45M,
                Stock = 10,
                InStock = true,
                IsPopular = false,
                CategoryId = 6
            }
            );


            //Tools and Brushes

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 26,
                BrandName = "Benecos",
                ProductName = "Eye Pencil Sharpener",
                Description = "Pencil Sharpener",
                LongDescription = "Pencil sharpener for cosmetic pencils. Sharpens two sizes with built in cleaner.",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/7a7d8903ef813f641c0f67f0198e9cd6356488cd_1400x.jpg?v=1594887356",
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/7a7d8903ef813f641c0f67f0198e9cd6356488cd_1400x.jpg?v=1594887356",
                Price = 5.25M,
                Stock = 10,
                InStock = true,
                IsPopular = true,
                CategoryId = 7
            }
  );

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 27,
                BrandName = "Benecos",
                ProductName = "Lip Brush",
                Description = "Long Lasting Lip Color",
                LongDescription = "For precise application and longer lasting lip colour 100% vegan soft toray fibre bristles with sustainable bamboo and recycled aluminium",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/597af5e1a3450ac87776d435033adff183b1533e_1400x.jpg?v=1485765184",
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/597af5e1a3450ac87776d435033adff183b1533e_1400x.jpg?v=1485765184",
                Price = 12.70M,
                Stock = 10,
                InStock = true,
                IsPopular = true,
                CategoryId = 7
            }
            );

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 28,
                BrandName = "Benecos",
                ProductName = "Eyeshadow Applicator",
                Description = "Easy Eyeshadow Application",
                LongDescription = "Foam head specially shaped for easy eyeshadow application. Made using bamboo, recycled aluminium and a latex foam head.",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/a6b7b74b475d47e349275fe44c12dbc83491095b_1400x.jpg?v=1584861380",
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/a6b7b74b475d47e349275fe44c12dbc83491095b_1400x.jpg?v=1584861380",
                Price = 8.15M,
                Stock = 10,
                InStock = true,
                IsPopular = false,
                CategoryId = 7
            }
            );

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 29,
                BrandName = "Forest Natural Skincare",
                ProductName = "Reusable Eco Bamboo Facial Pads",
                Description = "Remove Makeup, Cleanser or Masks",
                LongDescription = "Double layered Eco Bamboo Facial Pads are designed to be reusable therefore reducing waste caused by disposable facial pads. Forest Natural Skincare facial pads are bigger in size and more durable; they can be washed after use and dried for re-use. Perfect for removing makeup, cleanser or masks. Pack: 5 pads per pack Size: 8.5cm Material: 65% Bamboo 35% Cotton Skin Type: Dry, Normal, Oily, Combination, Sensitive Use: Wet the facial pad with lukewarm water, squeeze excess water and use it to wipe the skin with minimal pressure to remove cleansing oil, makeup or masks. Clean the facial pad with soapy water after use and hang dry.",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/4a67a9d0f1a8989f1f61ca54b4457838a1864a36_1400x.jpg?v=1568165580",
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/4a67a9d0f1a8989f1f61ca54b4457838a1864a36_1400x.jpg?v=1568165580",
                Price = 14.80M,
                Stock = 10,
                InStock = true,
                IsPopular = false,
                CategoryId = 7
            }
            );

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 30,
                BrandName = "The Natural Family Co",
                ProductName = "Toothbrush Twin Pack - Rivermint & Monsoon Mist",
                Description = "Biodegradable Package",
                LongDescription = "NFco Bio Toothbrush River Mint & Monsoon Mist - Twin Pack The NFco Bio Toothbrush is biodegradable along with its packaging. The handle is made from non-GMO corn starch with nylon bristles which are BPA free.",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/bf4eb1fec65c568e46b3625cd84a1b3d4b5e109d_1400x.jpg?v=1509674450",
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/bf4eb1fec65c568e46b3625cd84a1b3d4b5e109d_1400x.jpg?v=1509674450",
                Price = 11.30M,
                Stock = 10,
                InStock = true,
                IsPopular = false,
                CategoryId = 7
            }
            );


            //Food

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 31,
                BrandName = "Yes You Can",
                ProductName = "Vegan Egg Replacer with Organic Chia",
                Description = "Ideal for Baking",
                LongDescription = "Our Vegan Egg Replacer is ideal for baking if you are vegan or allergic to eggs. It is cholesterol free, gluten and dairy free, soy free, and non GMO. A guilt free and sustainable substitute to eggs for your cakes, breads, muffins, pancakes and other baking products. 180g. Ingredients: Gluten free rice flour, organic chia flour, natural raising agents(glucono-delta lactone, potassium bicarbonate), whole algal protein. Vegan. Gluten-free, GMO-free, dairy-free, soy-free. Health Benefits: Organic chia flour is rich in fibre, protein, and omega-3 fatty acids. It is also rich in calcium, antioxidants, vitamins and minerals. Algal protein is derived from algae containing high levels of healthy lipids, carbohydrates and amino acids. Cooking Instructions: To replace 1 egg: 1 tbsp of vegan egg replaer + 3 tbsp of water 1. Place 1 tablespoon of egg replacer in a bowl. 2. Add 3 tablespoons of water (at room temperature). 3. Stir with fork for approximately 30 seconds until mix is blended through. 4. Use mixture to replace 1 egg in your recipe.",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/3QbxaDrw_1400x.png?v=1569802860",
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/3QbxaDrw_1400x.png?v=1569802860",
                Price = 5.80M,
                Stock = 10,
                InStock = true,
                IsPopular = true,
                CategoryId = 1
            }
  );

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 32,
                BrandName = "Bio Cheese",
                ProductName = "Pizza Shreds 200g (cold)",
                Description = "Provides Mild Nutty Flavour",
                LongDescription = "Biocheese Pizza Shred is made with coconut oil, providing a mild nutty flavour that melts and stretches easily and evenly, without going oily. An ideal plant-based simulant shredded for your convenience in a resealable bag. Perfect for pizza, pasta, nachos and many more of your favourite dishes.",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/28443022c8b6b35e57e0ae9ba4bdc1c811ce8cec_1400x.png?v=1614204670",
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/28443022c8b6b35e57e0ae9ba4bdc1c811ce8cec_1400x.png?v=1614204670",
                Price = 10.70M,
                Stock = 10,
                InStock = true,
                IsPopular = true,
                CategoryId = 1
            }
            );

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 33,
                BrandName = "Dr McDougall's",
                ProductName = "Soup - Chicken Ramen",
                Description = "Vegan Ingredients",
                LongDescription = "*New Recipe* This delicious ramen soup is one of our very favorites. Nothing is more wonderful than sitting down to a bowl of hot ramen soup, and we’re proud to offer one made with Organic Ramen and vegan ingredients. Our soup is delicious, convenient, and always there when you need it. 51g. Ingredients: Organic Baked Ramen Noodles (Organic Wheat Flour, Brine, Salt), Yeast Extract, Vegetables* (Carrots, Garlic, Onion, Corn, Spinach), Organic Potato Starch, Organic Cane Sugar, Spices, Lime. *Dried. Vegan.",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/179233_1_1400x.jpg?v=1559260594",
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/179233_1_1400x.jpg?v=1559260594",
                Price = 3.85M,
                Stock = 10,
                InStock = true,
                IsPopular = false,
                CategoryId = 1
            }
            );

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 34,
                BrandName = "Beyond Meat",
                ProductName = "Beyond Burger 2pk 226g (cold)",
                Description = "Plant-based Burger",
                LongDescription = "The Beyond Burger is the world's first plant-based burger that looks, cooks, and tastes like a fresh beef burger. It has all the juicy, meat deliciousness of a traditional burger, but comes with the upsides of a plant-based meal. The Beyond Burger packs 20 g of plant-based protein and has no GMOs, soy or gluten. Plant based meat!",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/beyondburger_1400x.jpg?v=1591846447",
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/beyondburger_1400x.jpg?v=1591846447",
                Price = 16.95M,
                Stock = 10,
                InStock = true,
                IsPopular = false,
                CategoryId = 1
            }
            );

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 35,
                BrandName = "Cruelty Free Pantry",
                ProductName = "Vital Wheat Gluten Flour 500g",
                Description = "Make your own Seitan!",
                LongDescription = "Make your own Seitan! Seitan is made with Gluten Flour as the base ingredient, add flavourings, knead and cook to create all types of meat substitutes. There is a plethora of recipes avaialble online and even a Facebook group dedicated to Seitan lovers: The Vegan Seitan Appreciation Society. 75g of protein per 100g",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/CFS_Vital_Wheat_Gluten_Label_100x150mm_PRINT_copy_2_d774bf04-a618-485d-a42f-39edde37efcf_1400x.jpg?v=1614473522",
                ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0864/2280/products/CFS_Vital_Wheat_Gluten_Label_100x150mm_PRINT_copy_2_d774bf04-a618-485d-a42f-39edde37efcf_1400x.jpg?v=1614473522",
                Price = 9.95M,
                Stock = 10,
                InStock = true,
                IsPopular = false,
                CategoryId = 1
            }
            );


        }

    }
}
         


 