WITH TreeCTE AS (
    SELECT 
        node_id, 
        name, 
        parent_hub_id, 
        0 AS lvl,
        CAST(name AS VARCHAR(MAX)) AS sort_path
    FROM logistics_nodes
    WHERE parent_hub_id IS NULL
    
    UNION ALL
    
    SELECT 
        n.node_id, 
        n.name, 
        n.parent_hub_id, 
        t.lvl + 1,
        CAST(t.sort_path + ' > ' + n.name AS VARCHAR(MAX))
    FROM logistics_nodes n
    INNER JOIN TreeCTE t ON n.parent_hub_id = t.node_id
)
SELECT 
    node_id,
    REPLICATE('     ', lvl) + name AS [Иерархическое дерево],
    lvl AS [Уровень]
FROM TreeCTE
ORDER BY sort_path;