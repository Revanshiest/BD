WITH HierarchyCTE AS (
    SELECT node_id, name, node_type, parent_hub_id
    FROM logistics_nodes
    WHERE node_id = 1
    
    UNION ALL

    SELECT n.node_id, n.name, n.node_type, n.parent_hub_id
    FROM logistics_nodes n
    INNER JOIN HierarchyCTE h ON n.parent_hub_id = h.node_id
)
SELECT node_id, name, node_type, parent_hub_id 
FROM HierarchyCTE 
WHERE node_id <> 1;