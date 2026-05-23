SELECT 
    n1.name AS [Уровень 1 (Старт)],
    n2.name AS [Уровень 2 (Дети)],
    n3.name AS [Уровень 3 (Внуки)]
FROM logistics_nodes n1
LEFT JOIN logistics_nodes n2 ON n2.parent_hub_id = n1.node_id
LEFT JOIN logistics_nodes n3 ON n3.parent_hub_id = n2.node_id
WHERE n1.node_id = 1;