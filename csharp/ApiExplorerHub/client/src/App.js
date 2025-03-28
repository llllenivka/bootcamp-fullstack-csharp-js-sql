const App = () => {
  return (
    <div className="container mt-5">
      <div className="card">
        <div className="card-header">
          <h1>Список контактов</h1>
        </div>

        <div className="card-body">
          <table className="table table-hover">
            <thead>
              <tr>
                <th>#</th>
                <th>Имя</th>
                <th>E-mail</th>
              </tr>
            </thead>
            <tbody>

              <tr>
                <th>1</th>
                <th>Имя 3</th>
                <th>example1@gmail.com</th>
              </tr>

              <tr>
                <th>2</th>
                <th>Имя 2</th>
                <th>example2@gmail.com</th>
              </tr>

              <tr>
                <th>3</th>
                <th>Имя 1</th>
                <th>example3@gmail.com</th>
              </tr>

            </tbody>
          </table>
        </div>
      </div>

    </div>
  );
}

export default App;
