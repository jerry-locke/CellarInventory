using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using CellarInventoryWeb.Models;

namespace CellarInventoryWeb
{
    public class Startup
    {
        private const string EndpointUri = "https://cellarinventorydata.documents.azure.com:443/";
        private const string PrimaryKey = "3nc8sKSLCv8peT4FP1g4EqVg3ebj4eot2TZbXyhVBuUYazO3pHYoG2mog4f7Xv7KSVK5Kou0QxxN3QmnwvPxKA==";
        private DocumentClient client;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            client = new DocumentClient(new Uri(EndpointUri), PrimaryKey);
        }


        private async Task CreateInventoryDocumentIfNotExists(string databaseName, string collectionName, Inventory inventory)
        {
            try
            {
                await this.client.ReadDocumentAsync(UriFactory.CreateDocumentUri(databaseName, collectionName, inventory.Id));
            }
            catch (DocumentClientException de)
            {
                if (de.StatusCode == HttpStatusCode.NotFound)
                {
                    await this.client.CreateDocumentAsync(UriFactory.CreateDocumentCollectionUri(databaseName, collectionName), inventory);
                }
                else
                {
                    throw;
                }
            }        
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            // Register the IConfiguration instance 
            services.Configure<DocDbConfig>(Configuration);

            //Register the Item service
            services.AddTransient<IInventoryService, InventoryService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSingleton(client); //Add client to dependency injector
        }

        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
