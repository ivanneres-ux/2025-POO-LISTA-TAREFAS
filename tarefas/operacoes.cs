public class Operacoes
{
        private string connectionString = "";
    public int Criar(Tarefa tarefa)
    {
        using (var conexao = new MySqlConnection(connectionString))
        {
            conexao.Open();
            string sql = @"INSERT INTO tarefa (nome, descricao, DataCriacao, status, DataExecucao)
            VALUES (@nome, @descricao, @DataCriacao, @status, @DataExecucao);
            SELECT LAST_INSERT_ID();";
            using (var cmd = MySqlComand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@nome", tarefa.Nome);
                cmd.Parameters.AddWithValue("@descricao", tarefa.descricao);
                cmd.Parameters.AddWithValue("@DataCriacao", tarefa.DataCriacao);
                cmd.Parameters.AddWithValue("@status", tarefa.status);
                cmd.Parameters.AddWithValue("@DataExecucao", tarefa.DataExecucao);

                return Convert.ToInt32(cmd.ExecuterScalar());
            }
        }
    }

    public Tarefa Buscar (int Id)
    {
        return null;
    }
    public int Criar(Tarefa tarefa)
    {
        return 0;
    }
    public Tarefa Buscar(int id)
    {
        return null;
    }
    public List<Tarefa> Listar()
    {
        return Array.Empty<Tarefa>();
    }
    public void Alterar(Tarefa tarefa)
    {

    }
    public void Excluir(int id)
    {

    }
}