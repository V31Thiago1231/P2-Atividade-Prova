using System;

namespace LojaVirtual
{
    public class PedidoFactory : IPedidoFactory
    {
        private static int _ultimoId = 0;

        public IPedido CriarPedido(ICliente cliente)
        {
            if (cliente == null)
                throw new ArgumentNullException(nameof(cliente));

            if (!cliente.Validar())
                throw new ArgumentException("Cliente inválido");

            _ultimoId++;
            return new Pedido
            {
                Id = _ultimoId,
                Cliente = cliente,
                Data = DateTime.Now
            };
        }
    }
} 