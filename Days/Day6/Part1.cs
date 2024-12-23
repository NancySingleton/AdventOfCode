namespace AdventOfCode.Days.Day6;

public class Part1 : IDayPart
{
    private char[][] _grid = null!;
    private (int row, int col) _position = (0, 0);
    private bool _done;
    
    public int Solve()
    {
        _grid = Common.ReadInput();
        _position = GetStartPosition();

        while (!_done)
        {
            // Print();
            
            switch (_grid[_position.row][_position.col])
            {
                case '^':
                    MoveUp();
                    break;
                case 'v':
                    MoveDown();
                    break;
                case '<':
                    MoveLeft();
                    break;
                case '>':
                    MoveRight();
                    break;
                default:
                    throw new Exception("Don't know where to go!");
            }
        }
        
        return CountVisited();
    }
    
    private (int row, int col) GetStartPosition()
    {
        var result = _grid
            .SelectMany((row, rowIndex) => row.Select((c, colIndex) => (c, rowIndex, colIndex)))
            .First(x => x.c is '^' or 'v' or '<' or '>');

        return (result.rowIndex, result.colIndex);
    }

    private void MoveUp()
    {
        if (_position.row == 0)
        {
            _done = true;
            return;
        }

        for (var i = _position.row - 1; i >= 0; i--)
        {
            if (_grid[i][_position.col] == '#')
            {
                _grid[i+1][_position.col] = '>';
                _position = (i+1, _position.col);
                return;
            }
            _grid[i][_position.col] = 'X';
        }
        _done = true;
    }

    private void MoveDown()
    {
        if (_position.row == _grid.Length - 1)
        {
            _done = true;
            return;
        }

        for (var i = _position.row + 1; i < _grid.Length; i++)
        {
            if (_grid[i][_position.col] == '#')
            {
                _grid[i-1][_position.col] = '<';
                _position = (i-1, _position.col);
                return;
            }
            _grid[i][_position.col] = 'X';
        }
        _done = true;
    }

    private void MoveLeft()
    {
        if (_position.col == 0)
        {
            _done = true;
            return;
        }

        for (var i = _position.col - 1; i >= 0; i--)
        {
            if (_grid[_position.row][i] == '#')
            {
                _grid[_position.row][i+1] = '^';
                _position = (_position.row, i+1);
                return;
            }
            _grid[_position.row][i] = 'X';
        }
        _done = true;
    }

    private void MoveRight()
    {
        var width = _grid[0].Length - 1;
        if (_position.col == width)
        {
            _done = true;
            return;
        }

        for (var i = _position.col + 1; i <= width; i++)
        {
            if (_grid[_position.row][i] == '#')
            {
                _grid[_position.row][i-1] = 'v';
                _position = (_position.row, i-1);
                return;
            }
            _grid[_position.row][i] = 'X';
        }
        _done = true;
    }

    private void Print()
    {
        foreach (var row in _grid)
        {
            Console.WriteLine(new string(row));
        }
        Console.WriteLine("");
        Thread.Sleep(5000);
    }
    
    private int CountVisited()
    {
        return _grid.Sum(line => line.Count(c => c is 'X' or '<' or '>' or 'v' or '^'));
    }
}