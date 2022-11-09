
DespesaMes janeiro = new DespesaMes(1,125);
DespesaDia umJaneiro = new DespesaDia(1,janeiro,23);
DespesaDia dezJaneiro = new DespesaDia(10,janeiro,74);

DespesaMes dezembro = new DespesaMes(12,0);
DespesaDia cincoDezembro = new DespesaDia(5, dezembro, 165);
DespesaDia quinzeDezembro = new DespesaDia(15, dezembro, 234);

List<DespesaMes> despesas = new List<DespesaMes>();
despesas.Add(janeiro);
despesas.Add(dezembro);

Despesas fulano = new Despesas("123.456.789-10", despesas);
fulano.DespesasTotal[0] = janeiro;
fulano.DespesasTotal[1] = dezembro;

Console.WriteLine($"Despesas de Janeiro: {fulano.Total(1)}");
Console.WriteLine($"Despesas de Dezembro: {fulano.Total(2)}");
//aaaaaaaaaaaaaaaaaaaaaaaaaaaaa