
using InvoiceAPIApp.Repository.Invoice;
using InvoiceAPIApp.Services.InvoiceService;
using InvoiceAPIApp.Services.PurchaseOrderService;
using Unity;
using Unity.Lifetime;

namespace InvoiceAPIApp
{
    public static class DependencyInjectionContainerHandler
    {
        public static UnityContainer setupContainer(UnityContainer container)
        {
            container.RegisterType<InvoiceRepository, InvoiceRepositoryImpl>(new HierarchicalLifetimeManager());
            container.RegisterType<PurchaseOrderRepository, PurchaseOrderRepositoryImpl>(new HierarchicalLifetimeManager());
            container.RegisterType<InvoiceService, InvoiceServiceImpl>(new HierarchicalLifetimeManager());
            container.RegisterType<PurchaseOrderService, PurchaseOrderServiceImpl>(new HierarchicalLifetimeManager());

            return container;
        }
    }
}
