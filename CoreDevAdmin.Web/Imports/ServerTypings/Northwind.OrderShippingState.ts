namespace CoreDevAdmin.Northwind {
    export enum OrderShippingState {
        NotShipped = 0,
        Shipped = 1
    }
    Serenity.Decorators.registerEnumType(OrderShippingState, 'CoreDevAdmin.Northwind.OrderShippingState', 'Northwind.OrderShippingState');
}
