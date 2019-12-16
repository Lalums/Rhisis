QUEST_DREADKREN = {
	title = 'IDS_PROPQUEST_INC_001222',
	character = 'MaFl_Gergantes',
	start_requirements = {
		min_level = 30,
		max_level = 39,
		job = { 'JOB_MERCENARY', 'JOB_ACROBAT', 'JOB_ASSIST', 'JOB_MAGICIAN' },
	},
	rewards = {
		gold = 0,
	},
	dialogs = {
		begin = {
			'IDS_PROPQUEST_INC_001223',
			'IDS_PROPQUEST_INC_001224',
			'IDS_PROPQUEST_INC_001225',
			'IDS_PROPQUEST_INC_001226',
			'IDS_PROPQUEST_INC_001227',
		},
		begin_yes = {
			'IDS_PROPQUEST_INC_001228',
		},
		begin_no = {
			'IDS_PROPQUEST_INC_001229',
		},
		completed = {
			'IDS_PROPQUEST_INC_001230',
			'IDS_PROPQUEST_INC_001231',
			'IDS_PROPQUEST_INC_001232',
		},
		not_finished = {
			'IDS_PROPQUEST_INC_001233',
		},
	}
}