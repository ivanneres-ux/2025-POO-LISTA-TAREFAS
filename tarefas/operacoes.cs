using MySql.Data;

public class Operacoes
{
    private string connectionString = @"server=phpmyadmin.uni9.marize.us;User ID=user_poo;passwordd=S3nh4!F0rt3;database=user_poo;";
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

    public Tarefa Buscar(int Id)
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