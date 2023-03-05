namespace LMSAPI.Timetable.Data_Structures;

public class RedBlackTree<T> : IOrderedSet<T> where T: IComparable
{
    private string _color = "Black";
    private T? _content;  // returns null if T is a class type

    public RedBlackTree<T>? LeftTree { get; set; }

    public RedBlackTree<T>? RightTree { get; set; }

    public RedBlackTree<T>? Parent { get; set; }

    public T? Content
    {
        get => _content;
        set => _content = value;
    }

    public bool IsEmpty => _content == null;

    public bool IsLeaf
    {
        get
        {
            if (LeftTree != null && RightTree != null)
            {
                if (LeftTree.IsEmpty && RightTree.IsEmpty && _content != null)
                    return true;
            }
            return false;
        }
    }

    public RedBlackTree<T>? Sibling
    {
        get
        {
            if (Parent is {RightTree: { }} && Parent.RightTree._content != null 
                                           && !Parent.RightTree._content.Equals(_content))
                return Parent.RightTree;
            
            if (Parent is {LeftTree: { }} && Parent.LeftTree._content != null 
                                          && !Parent.LeftTree._content.Equals(_content))
                return Parent.LeftTree;

            return null;
        }
    }

    public RedBlackTree() {  }

    public RedBlackTree(T item)
    {
        _content = item;
        LeftTree = new RedBlackTree<T>();
        RightTree = new RedBlackTree<T>();
    }

    /// <summary>
    /// Prints the tree onto the console. Uses the .ToString() for printing out object info
    /// </summary>
    /// <param name="tree">A node in the tree</param>
    public void Show()
    {
        Show("");
    }

    /// <summary>
    /// Prints the tree onto the console. Uses the .ToString() for printing out object info
    /// </summary>
    /// <param name="tree">A node in the tree</param>
    /// <param name="tabs">The number of tabs to offset the println()</param>
    private void Show(string tabs)
    {
        if (IsEmpty)
        {
            Console.WriteLine(tabs + " --NULL [" + _color + "]");
            return;
        }

        Console.WriteLine(tabs + " -" + Content + " [" + _color + "]");
        LeftTree?.Show(tabs + "  ");
        RightTree?.Show(tabs + "  ");
    }

    public IOrderedSet<T> MakeCopy()
    {
        if (IsEmpty)
            return new RedBlackTree<T>();

        RedBlackTree<T> newTree = new RedBlackTree<T>(_content);
        newTree._color = _color;

        RedBlackTree<T> leftSubtreeCopy = (RedBlackTree<T>) LeftTree.MakeCopy();
        RedBlackTree<T> rightSubtreeCopy = (RedBlackTree<T>) RightTree.MakeCopy();

        newTree.LeftTree = leftSubtreeCopy;
        leftSubtreeCopy.Parent = newTree;
        newTree.RightTree = rightSubtreeCopy;
        rightSubtreeCopy.Parent = newTree;
        return newTree;
    }

    public bool Contains(T item)
    {
        if (IsEmpty)
            return false;

        if (_content.Equals(item))
            return true;

        if (LeftTree != null && item.CompareTo(_content) < 0)
            return LeftTree.Contains(item);
        else if (RightTree != null && item.CompareTo(_content) > 0)
            return RightTree.Contains(item);
        else
            return false;
    }

    public bool CanAdd(T newItem)
    {
        if (IsEmpty)
            return true;

        if (LeftTree != null && newItem.CompareTo(_content) < 0)
            return LeftTree.CanAdd(newItem);
        else if (RightTree != null && newItem.CompareTo(_content) > 0)
            return RightTree.CanAdd(newItem);
        else
            return false;
    }

    public bool Add(T newItem)
    {
        // If it is an empty tree
        if (IsEmpty)
        {
            _content = newItem;
            _color = "Black";
            LeftTree = new RedBlackTree<T>();
            RightTree = new RedBlackTree<T>();
            return true;
        }

        // Left tree
        if (newItem.CompareTo(_content) < 0)
        {
            if (LeftTree.IsEmpty)
            {
                LeftTree = new RedBlackTree<T>(newItem);
                LeftTree.Parent = this;
                LeftTree._color = "Red";
                RebalanceTree(LeftTree);
                return true;
            }
            else
                return LeftTree.Add(newItem);
        }

        // Right tree
        else if (newItem.CompareTo(_content) > 0)
        {
            if (RightTree.IsEmpty)
            {
                RightTree = new RedBlackTree<T>(newItem);
                RightTree.Parent = this;
                RightTree._color = "Red";
                RebalanceTree(RightTree);
                return true;
            }
            else
                return RightTree.Add(newItem);
        }
        return false;
    }

    private void RebalanceTree(RedBlackTree<T> addedItem)
    {
        // Case 1
        if (_color == "Black")
            return;

        // Case 2
        else if (_color == "Red" && Sibling != null)
        {
            // Case 2A:
            if (Sibling.IsEmpty || Sibling._color == "Black")
            {
                if (addedItem == LeftTree && this == Parent.LeftTree)
                    PerformInsertionReordering1(addedItem);

                else if (addedItem == RightTree && this == Parent.LeftTree)
                    PerformInsertionReordering2(addedItem);

                else if (addedItem == RightTree && this == Parent.RightTree)
                    PerformInsertionReordering3(addedItem);

                else if (addedItem == LeftTree && this == Parent.RightTree)
                    PerformInsertionReordering4(addedItem);
            }

            // Case 2B:
            else if (Sibling._color == "Red")
            {
                PerformInsertionRecoloring(addedItem);
            }
        }
    }

    private void PerformInsertionReordering1(RedBlackTree<T> newNode)
    {
        RedBlackTree<T> k = newNode;
        RedBlackTree<T> p = this;
        RedBlackTree<T> g = Parent;
        RedBlackTree<T> s = Sibling;

        RedBlackTree<T> newG = new RedBlackTree<T>(g._content);
        newG._color = "Red";
        newG.LeftTree = p.RightTree;
        p.RightTree.Parent = newG;
        newG.RightTree = s;
        s.Parent = newG;

        g._content = p._content;
        g.LeftTree = k;
        k.Parent = g;
        g.RightTree = newG;
        newG.Parent = g;
    }

    private void PerformInsertionReordering2(RedBlackTree<T> newNode)
    {
        RedBlackTree<T> k = newNode;
        RedBlackTree<T> p = this;
        RedBlackTree<T> g = Parent;
        RedBlackTree<T> s = Sibling;

        RedBlackTree<T> newG = new RedBlackTree<T>(g._content);
        newG._color = "Red";
        newG.RightTree = s;
        s.Parent = newG;

        g._content = k._content;
    }

    private void PerformInsertionReordering3(RedBlackTree<T> newNode)
    {
        RedBlackTree<T> k = newNode;
        RedBlackTree<T> p = this;
        RedBlackTree<T> g = Parent;
        RedBlackTree<T> s = Sibling;

        RedBlackTree<T> newG = new RedBlackTree<T>(g._content);
        newG._color = "Red";
        newG.LeftTree = s;
        s.Parent = newG;
        newG.RightTree = p.LeftTree;
        p.LeftTree.Parent = newG;

        g._content = p._content;
        g.LeftTree = newG;
        newG.Parent = g;
        g.RightTree = k;
        k.Parent = g;
    }

    private void PerformInsertionReordering4(RedBlackTree<T> newNode)
    {
        RedBlackTree<T> k = newNode;
        RedBlackTree<T> p = this;
        RedBlackTree<T> g = Parent;
        RedBlackTree<T> s = Sibling;

        RedBlackTree<T> newG = new RedBlackTree<T>(g._content);
        newG._color = "Red";
        newG.LeftTree = s;
        s.Parent = newG;
        newG.RightTree = p.LeftTree;
        p.LeftTree.Parent = newG;

        g._content = p._content;
        g.LeftTree = newG;
        newG.Parent = g;
        g.RightTree = k;
        k.Parent = g;
    }

    private void PerformInsertionRecoloring(RedBlackTree<T> newNode)
    {
        RedBlackTree<T> k = newNode;
        RedBlackTree<T> p = this;
        RedBlackTree<T> g = Parent;
        RedBlackTree<T> s = Sibling;

        g._color = "Red";
        p._color = "Black";
        s._color = "Black";

        // Handle case if g is the root node
        if (g.Parent == null)
            g._color = "Black";

        else if (g.Parent._color == "Red")
            g.Parent.RebalanceTree(g);
    }

    public bool Delete(T item)
    {
        throw new NotImplementedException();
    }

    public List<T> GetContents()
    {
        if (IsEmpty)
            return new List<T>();

        List<T> contents = new List<T>();
        if (!LeftTree.IsEmpty)
            contents.AddRange(LeftTree.GetContents());
        contents.Add(_content);
        if (!RightTree.IsEmpty)
            contents.AddRange(RightTree.GetContents());
        return contents;
    }
}