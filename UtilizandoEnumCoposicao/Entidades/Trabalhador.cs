using System;
using System.Collections.Generic;
using UtilizandoEnumCoposicao.Entidades.Enumeradores;
using UtilizandoEnumCoposicao.Entities;

namespace UtilizandoEnumCoposicao.Entidades
{
    class Trabalhador
    {

        public string Nome { get; set; }
        public NivelTrabalhador Nivel { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<ContratoHoras> Contratos { get; set; } = new List<ContratoHoras>();

        public Trabalhador()
        {
        }


        // Lista não vai no construtor, cria sempre uma método a parte para adicionar e remover (conforme abaixo)
        public Trabalhador(string nome, NivelTrabalhador nivel, double salarioBase, Departamento departamento)
        {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AdicionarContrato(ContratoHoras contrato)
        {
            Contratos.Add(contrato);
        }

        public void RemoveContrato(ContratoHoras contrato)
        {
            Contratos.Remove(contrato);
        }

        public double Renda(int ano, int mes)
        {
            double soma = SalarioBase;
      
            foreach (var item in Contratos)
            {
                if (item.Data.Year == ano && item.Data.Month == mes)
                {
                    soma += item.Horas * item.ValorPorHoras;
                }

            }

            return soma;
        }
    }
}
